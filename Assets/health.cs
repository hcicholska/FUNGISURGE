using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public float healthPoints = 300f;
    public int maxHealthPoints = 300;
    public Slider healthSlider;
    public GameObject backgroundObject;
    

    private void Start()
    {
        healthSlider.maxValue = healthPoints;
        
    }

    
    private void Update()
    {
        healthSlider.value = healthPoints;
       if (healthPoints <= 0)
        {
            backgroundObject.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            backgroundObject.SetActive(false);
        }

       if (healthPoints > maxHealthPoints) 
        { 
            healthPoints = maxHealthPoints;
        }
    }
    
public void TakeDamage(float damage)
    {
        healthPoints -= damage;
    }

}