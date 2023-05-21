using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Potion : MonoBehaviour
{
    
    public int potionHealthPoints = 50;
    public void OnTriggerEnter(Collider other)
    {
      
        health health = other.GetComponent<health>();
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.PotionCollected();
            gameObject.SetActive(false);
        }

        other.GetComponent<health>().healthPoints += potionHealthPoints;
        
    
       
    }
}
