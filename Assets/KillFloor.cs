using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillFloor : MonoBehaviour
{
    public Transform respawnPoint;
    
    
    private void OnTriggerEnter(Collider other)
    {
        CharacterController player = other.GetComponent<CharacterController>();
    
        if (player != null)
        {
            
            player.enabled = false;
            // Przywrócenie gracza do punktu respawnu
            player.transform.position = respawnPoint.position;
            player.enabled = true;
        }
    }
}
