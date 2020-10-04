using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public static SliderController controller;
    int progress = 0;
    public Slider slider;
    public float sliderFillSpeed;

    // Start is called before the first frame update
    void Start()
    {
        if (controller == null)
        {
            controller = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < progress)
        {
            slider.value += sliderFillSpeed * Time.deltaTime;
        }
    }

    public void SetProgress(int progress)
    {
        if (progress > this.progress)
        {
            this.progress = progress;
        }
    }
}
