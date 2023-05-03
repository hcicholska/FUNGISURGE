using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public int health = 40;

    public void OnMouseDown() {
        health -= 10;
        if (health <= 0) {
            Destroy(gameObject);
        }
    }
} 