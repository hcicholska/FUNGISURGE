using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    private Vector3 lastCheckpointPosition;
    private Checkpoint lastActivatedCheckpoint;

    public void SetCheckpoint(Vector3 position)
    {
        lastCheckpointPosition = position;
    }

    public void ActivateCheckpoint(Checkpoint checkpoint)
    {
        lastActivatedCheckpoint = checkpoint;
    }

    public bool HasAcvtivatedCheckpoint(Checkpoint checkpoint)
    {
        return checkpoint == lastActivatedCheckpoint;
    }

    public Vector3 GetLastCheckpointPosition()
    {
        return lastCheckpointPosition;
    }
}