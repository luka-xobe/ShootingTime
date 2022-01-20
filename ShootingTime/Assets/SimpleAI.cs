using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleAI : MonoBehaviour
{
    public float lookRadius = 10f;

    Transform target;
    Animator animator;
    NavMeshAgent agent;
   
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

 
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
       

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
            Debug.Log("WORKI");
            //if (distance <= agent.stoppingDistance)
            //{
            // attack the target
            // face the target 
            // }

            animator.SetBool("Idle", false);
            animator.SetBool("Move", true);

            if (distance <= 5f)
            {
                animator.SetBool("Move", false);
                animator.SetBool("Idle", true);
                animator.SetBool("Fire", true);
                Debug.Log("SHOOOOTIn");
            }
           


        }
        else 
        {
            animator.SetBool("Move", false);
            animator.SetBool("Idle", true);
        }
        
    }



    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, lookRadius) ;
    }
}
