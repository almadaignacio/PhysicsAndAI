using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proiyectile : MonoBehaviour
{
    public float bulletForce;
    public Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * bulletForce, ForceMode.Impulse);
        rb.mass = 2;
    }

}
