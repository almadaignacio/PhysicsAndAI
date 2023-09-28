using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Proiyectile : MonoBehaviour
{
    public float bulletForce;
    public Rigidbody rb;
    public Text UI;
    public int objectsBroken;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        UI = GameObject.FindGameObjectWithTag("EditorOnly").GetComponent<Text>();
        rb.AddRelativeForce(Vector3.forward * bulletForce, ForceMode.Impulse);
        rb.mass = 2;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("barrel"))
        {
            objectsBroken++;
            UI.text = objectsBroken.ToString();
        }
    }

}
