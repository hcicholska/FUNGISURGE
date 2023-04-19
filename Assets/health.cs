using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public float healthPoints = 300f;
    public Slider healthSlider;
public GameObject backgroundObject;

    private void Start()
    {
        healthSlider.maxValue = healthPoints;
        
    }

    
    private void Update()
    {
        healthSlider.value = healthPoints;
       if (healthPoints <= 0 && !backgroundObject.activeSelf)
        {
            backgroundObject.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            backgroundObject.SetActive(false);
           
        }
    }

}
