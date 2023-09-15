using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objects : MonoBehaviour
{
    public Text text;
    public float breakF;

    private void Update()
    {
        //text.text = breakF.ToString();
    }

    private void OnJointBreak(float breakForce)
    {
         float breakF = breakForce;
        text.text = breakForce.ToString();
    }
}
