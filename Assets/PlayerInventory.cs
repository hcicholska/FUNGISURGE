using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfPotions { get; private set; }

    public void PotionCollected()
    {
        NumberOfPotions++;
    }
  
}
