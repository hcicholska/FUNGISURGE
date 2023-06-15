using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class dziadDetection : MonoBehaviour
{ 
    public float detectionRadius;
    public float stopDistance = 2f;
    public float detectionRadiusWithShift = 1f;
    public Transform player;
    public NavMeshAgent enemy;
    private bool isFollowing;
    public float attackDistance = 2;
    public Animator animator;
    
    

    private void Start()
    {
        
        animator.SetBool("isWalking", true);
    }
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
            Debug.Log(distanceToPlayer + " <= " + detectionRadius);
        if (distanceToPlayer <= detectionRadius)
        {
            
            isFollowing = true;
            animator.SetBool("isBoxing", false);
            animator.SetBool("isWalking", true);
        }
       

        if (distanceToPlayer <= attackDistance)
        {
            isFollowing = true;
            animator.SetBool("isBoxing", true);
            animator.SetBool("isWalking", false);
        

        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            detectionRadius = detectionRadiusWithShift;
            isFollowing = false;
        }
        else
        {
            detectionRadius = 25f;
        }

        if (isFollowing)
        {
            enemy.SetDestination(player.transform.position);
        }

        if (distanceToPlayer <= stopDistance)
        {
            isFollowing = false;
            enemy.SetDestination(transform.position);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            detectionRadius = detectionRadiusWithShift;
            isFollowing = false;
        }

        
    }
}