using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAgent : MonoBehaviour
{
    [SerializeField] string targetName = "EnemyTarget";
    public float maxHealth = 20f;
    
    private NavMeshAgent agent;
    public float currentHealth;

    private EnemyHpBar hpBar;

    private void Start()
    {
        currentHealth = maxHealth;

        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(GameObject.Find(
            targetName).transform.position);

        hpBar = GetComponentInChildren<EnemyHpBar>();
    }
    public void TakeDamage(float damage)
    {
        if (currentHealth > damage && currentHealth > 0)
        {
            currentHealth -= damage;
        }
        else 
        {
            Destroy(gameObject);
        }
    }
}
