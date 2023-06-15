using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillFloor : MonoBehaviour
{
    public Transform respawnPoint;
    public AudioSource restart;
    public CheckpointManager checkpointManager;
    
    
    private void OnTriggerEnter(Collider other)
    {
        CharacterController player = other.GetComponent<CharacterController>();
    
        if (player != null)
        {
            restart.Play();
            player.enabled = false;
            // Przywrócenie gracza do punktu respawnu
            //player.transform.position = respawnPoint.position;
            Vector3 lastCheckpointPosition = checkpointManager.GetLastCheckpointPosition();
            // Przywróć gracza do pozycji ostatniego checkpointu
            player.transform.position = lastCheckpointPosition;
            player.enabled = true;
        }
    }
}
