using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy1 : MonoBehaviour
{
    public Transform player;
    public float moveDuration = 2f;
    public float stopDuration = 3f;

    private NavMeshAgent navMeshAgent;
    private bool isMoving = true;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        if (player != null)
        {

            navMeshAgent.SetDestination(player.position);
        }
    }

    private void Update()
    {
        if (player != null && !navMeshAgent.pathPending && navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {

            StopMovement();
        }
    }

    private void StopMovement()
    {
        isMoving = false;
        navMeshAgent.isStopped = true;
        Invoke(nameof(ResumeMovement), stopDuration);
    }

    private void ResumeMovement()
    {
        isMoving = true;
        navMeshAgent.isStopped = false;

        if (player != null)
        {

            navMeshAgent.SetDestination(player.position);
        }

        Invoke(nameof(StopMovement), moveDuration);
    }
}
