using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    public int arrowAmmunition = 1;

    public void OnTriggerEnter(Collider other)
    {
        ammunition ammunition = other.GetComponent<ammunition>();
        PlayerInventory playerInventory= other.GetComponent<PlayerInventory>();

        if (playerInventory != null) 
        {
            playerInventory.ArrowCollected();
            gameObject.SetActive(false);
        }

        other.GetComponent<ammunition>().ammunitionQuantity += arrowAmmunition;
    }
}
