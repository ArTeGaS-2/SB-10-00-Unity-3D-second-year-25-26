using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [Header("Об'єкти")]
    [SerializeField] GameObject projectilePrefab;

    [Header("Параметри вежі")]
    [SerializeField] float attackInterval = 1f;
    [SerializeField] float attackDamage = 1f;
    [SerializeField] float attackRadius = 5f;

    private List<GameObject> enemiesInRadius;

    private void Awake()
    {
        enemiesInRadius = new List<GameObject>();
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}
