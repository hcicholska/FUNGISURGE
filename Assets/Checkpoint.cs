using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Vector3 playerPosition;
    public CheckpointManager checkpointManager;
    public AudioSource checkpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            checkpoint.Play();
            checkpointManager.SetCheckpoint(transform.position);
        }
    }

    public Vector3 GetPlayerPosition()
    {
        return playerPosition;
    }
}
