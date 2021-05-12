using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLightConditions : MonoBehaviour
{
    public Light[] lights;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var sliderColor = slider.value;

        var newColor = new Color(sliderColor, sliderColor, sliderColor);

        foreach(Light light in lights)
        {
            light.color = newColor;
        }
    }
}
