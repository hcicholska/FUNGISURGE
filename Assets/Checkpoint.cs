using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Vector3 playerPosition;
    public CheckpointManager checkpointManager;
    public AudioSource checkpoint;
    public Animator flagAnimator;
    public ParticleSystem checkpointParticles;

    private bool isSoundPlayed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isSoundPlayed)
        {
            isSoundPlayed = true;
            
            checkpoint.Play();
            checkpointManager.SetCheckpoint(transform.position);

            flagAnimator.SetTrigger("PlayCheckpointFlagAnimation");
            
            checkpointParticles.Play();

        }
    }

    public Vector3 GetPlayerPosition()
    {
        return playerPosition;
    }
}
