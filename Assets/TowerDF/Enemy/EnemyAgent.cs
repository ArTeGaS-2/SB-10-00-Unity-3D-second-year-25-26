using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAgent : MonoBehaviour
{
    [SerializeField] string targetName = "EnemyTarget";
    [SerializeField] float maxHealth = 20f;
    
    private NavMeshAgent agent;
    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;

        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(GameObject.Find(
            targetName).transform.position);
    }
}
