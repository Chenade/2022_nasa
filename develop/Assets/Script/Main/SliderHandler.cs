using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderHandler : MonoBehaviour
{
    public Slider _slider;
    void Start()
    {
        _slider.onValueChanged.AddListener((v) => {
            MainSystem.time_rate = v;
            MainSystem.delta_time_change = true;
        });
    }

    void Update()
    {
        
    }
}
