using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Canon : MonoBehaviour
{
    public GameObject baseCanon;
    public GameObject canon;
    public GameObject proyectile;
    public Transform proyectilePosition;
    public Proiyectile proyectileScript;
    public Rigidbody proyectileRb;
    public Text textForce;
    public Text textMass;
    public Text textBullets;
    public GameObject shootButton;
    public GameObject backToShootButton;
    public GameObject camera1;
    public GameObject panelProperties;
    public GameObject noBulletsLeft;
    public GameObject restartButton;

    public CheckInfo checkInfo;

    public VerticalRotation sliderInfo;
    public Slider verticalslider;

    public int bullets;
    bool canShoot;
    public float x;
    public float y;

    public float startX;
    public float startY;
    public float startWeight;
    public float startForce;

    public Text infoText;
    public Text yText;
    public Text xText;


    private void Start()
    {
        checkInfo = GameObject.FindGameObjectWithTag("CheckInfo").GetComponent<CheckInfo>();
        proyectileScript = GameObject.FindGameObjectWithTag("Proyectile").GetComponent<Proiyectile>(); 
        proyectileRb = GameObject.FindGameObjectWithTag("Proyectile").GetComponent<Rigidbody>();
        
        bullets = 5;
        canShoot = true;

        
    }

    private void Update()
    {
        //canon.transform.Rotate(0, 0.5f, 0);
        startX = sliderInfo.x;
        startY = sliderInfo.y;

        infoText.text = "Last Shot: X: " + startX.ToString() + ", Y: " + startY.ToString() + ", Mass " + proyectileRb.mass.ToString() + ", Force " + proyectileScript.bulletForce.ToString();

        xText.text = "Y angle: " + startX.ToString();
        yText.text = "X angle: " + startY.ToString();

        Information();
    }

    public void ForcePlus()
    {
        proyectileScript.bulletForce++;
    }    
    public void ForceMinus()
    {
        proyectileScript.bulletForce--;
    }

    public void MassPlus()
    {
        proyectileRb.mass++;
    }

    public void MassMinus()
    {
        proyectileRb.mass--;
    }

    public void Horizontal(float newX)
    {
        x = newX;
    }

    public void Vertical(float newY)
    {
        y = newY;
    }

    public void Shoot()
    {
        GameObject fire = Instantiate(proyectile, proyectilePosition.position, proyectilePosition.rotation);
        bullets--;
    }

    public void Information()
    {
        textForce.text = proyectileScript.bulletForce.ToString();
        textMass.text = proyectileRb.mass.ToString();
        textBullets.text = bullets.ToString();

        if (proyectileRb.mass <= 1)
        {
            proyectileRb.mass = 1;
        }

        if (proyectileRb.mass >= 15)
        {
            proyectileRb.mass = 15;
        }

        if (proyectileScript.bulletForce <= 15)
        {
            proyectileScript.bulletForce = 15;
        }

        if (proyectileScript.bulletForce >= 75)
        {
            proyectileScript.bulletForce = 75;
        }

        if (bullets == 0)
        {
            shootButton.SetActive(false);
            noBulletsLeft.SetActive(true);
            restartButton.SetActive(true);
        }
    }

    public void BackToShoot()
    {
        camera1.SetActive(false);
        backToShootButton.SetActive(false);
    }

    public void ChangeView()
    {
        camera1.SetActive(true);
        backToShootButton.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("cañones");
    }
}
