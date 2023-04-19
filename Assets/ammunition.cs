using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammunition : MonoBehaviour
{
    public float ammunitionQuantity = 20f;
    public Slider ammunitionSlider;

   
    private void Start()
    {
        ammunitionSlider.maxValue = ammunitionQuantity;
    }
    private void Update()
    {
        ammunitionSlider.value = ammunitionQuantity;
    }
}

    
    

