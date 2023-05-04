using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log ("kolizja jest");
        if (collision.gameObject.CompareTag("Player"))
        {
            health health = collision.gameObject.GetComponent<health>();
            if (health != null)
            {
                health.TakeDamage(10f);
            }
        }
    }
}
