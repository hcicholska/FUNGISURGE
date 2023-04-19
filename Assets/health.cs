using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public float healthPoints = 300f;
    public Slider healthSlider;


    private void Start()
    {
        healthSlider.maxValue = healthPoints;
    }

    
    private void Update()
    {
        healthSlider.value = healthPoints;
       
    }
}
