using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
    public float shotDistance = 100f;
    public LayerMask enemyLayer;
    public ParticleSystem shootingParticles;
    private CharacterController conn;
    public int shot = 1;
    private ammunition ammunition;
    private void Start()
    {
        conn = GetComponent<CharacterController>();
        ammunition = GetComponent<ammunition>();
    }

    void Update () 
    {
        
        if (Input.GetMouseButtonDown(0) && ammunition.ammunitionQuantity > 0) 
        {
            ammunition.ammunitionQuantity -= shot;

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             
            Vector3 playerMovement = conn.velocity;
            Vector3 shootDirection = playerMovement != Vector3.zero ? playerMovement.normalized : transform.forward;
            ParticleSystem.VelocityOverLifetimeModule velocityModule = shootingParticles.velocityOverLifetime;
            velocityModule.enabled = true;
            velocityModule.x = shootDirection.x;
            velocityModule.y = shootDirection.y;
            velocityModule.z = shootDirection.z;
            shootingParticles.Play();
            if (Physics.Raycast(ray, out hit, shotDistance, enemyLayer)) {
                EnemyScript enemyScript = hit.collider.GetComponent<EnemyScript>();
                if (enemyScript != null) {
                    enemyScript.OnMouseDown();
                }
            }
        }
    }
}