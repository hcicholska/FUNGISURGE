using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammunition : MonoBehaviour
{
    public float ammunitionQuantity = 50f;
    public float maxAmmunitionQuantity = 50f;
    public float minimumAmmunitionQuantity = 0f;
    public Slider ammunitionSlider;

   
    private void Start()
    {
        ammunitionSlider.maxValue = ammunitionQuantity;
    }
    private void Update()
    {
        ammunitionSlider.value = ammunitionQuantity;

        if (ammunitionQuantity > maxAmmunitionQuantity) 
        { 
            ammunitionQuantity = maxAmmunitionQuantity;
        }

        if (ammunitionQuantity < minimumAmmunitionQuantity)
        {
            ammunitionQuantity = minimumAmmunitionQuantity;
        }
    }
}

    
    

