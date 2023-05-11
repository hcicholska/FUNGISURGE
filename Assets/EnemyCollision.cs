using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            health health = other.gameObject.GetComponent<health>();
            if (health != null)
            {
                health.TakeDamage(10f);
            }
        }
    }
}

