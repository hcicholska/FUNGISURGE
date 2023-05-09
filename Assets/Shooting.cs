using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
    public float shotDistance = 100f;
    public LayerMask enemyLayer;

    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, shotDistance, enemyLayer)) {
                EnemyScript enemyScript = hit.collider.GetComponent<EnemyScript>();
                if (enemyScript != null) {
                    enemyScript.OnMouseDown();
                }
            }
        }
    }
}