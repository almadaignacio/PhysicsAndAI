using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    private void Start()
    {
        proyectileScript = GameObject.FindGameObjectWithTag("Proyectile").GetComponent<Proiyectile>(); 
        proyectileRb = GameObject.FindGameObjectWithTag("Proyectile").GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject fire = Instantiate(proyectile, proyectilePosition.position, proyectilePosition.rotation);
        }

        if (Input.GetKey(KeyCode.A))
        {
            baseCanon.transform.Rotate(0, -0.5f, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            baseCanon.transform.Rotate(0, 0.5f, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            canon.transform.Rotate(0, -0.5f, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            canon.transform.Rotate(0, 0.5f, 0);
        }

        textForce.text = proyectileScript.bulletForce.ToString();
        textMass.text = proyectileRb.mass.ToString();

        if (proyectileRb.mass <= 1)
        {
            proyectileRb.mass = 1;
        } 

        if(proyectileRb.mass >= 15)
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

}
