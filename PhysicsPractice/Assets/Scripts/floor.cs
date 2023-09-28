using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class floor : MonoBehaviour
{
    public Text UI;
    public int objectsBroken;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("barrel"))
        {
            objectsBroken++;
            Debug.Log("hit");
            UI.text = objectsBroken.ToString();
        }
    }
}
