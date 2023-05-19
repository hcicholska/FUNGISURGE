using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UIElements;

public class Potion : MonoBehaviour
{
    public AudioClip pickupSound; //muzyczka
    public int potionHealthPoints = 50;
    public void OnTriggerEnter(Collider other)
    {
      
        health health = other.GetComponent<health>();
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        AudioSource.PlayClipAtPoint(pickupSound, transform.position, 100f); //muzyczka

        if (playerInventory != null)
        {
            playerInventory.PotionCollected();
            gameObject.SetActive(false);
        }

        other.GetComponent<health>().healthPoints += potionHealthPoints;
        
        
        
        
       
    }
}
