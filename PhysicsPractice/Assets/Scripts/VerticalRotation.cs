using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerticalRotation : MonoBehaviour
{
    public Slider horizontalSlider;
    public Slider verticalSlider;
    public float x;
    public float y;

    void Update()
    {
        x = verticalSlider.value * 10;
        y = horizontalSlider.value * 10;
        this.transform.rotation = Quaternion.Euler(x, y, 90);
    }
}
