using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HorizontalRotation : MonoBehaviour
{
    public Slider horizontalSlider;
    public float x;

    void Update()
    {
        x = horizontalSlider.value * 10f;
        this.transform.rotation = Quaternion.Euler(0, x, 0);
    }
}
