using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [Header("Об'єкти")]
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] GameObject spawnPoint; 

    [Header("Параметри вежі")]
    [SerializeField] float attackInterval = 1f;
    [SerializeField] float attackDamage = 1f;
    [SerializeField] float attackRadius = 5f;

    private List<GameObject> enemiesInRadius; // Список ворогів у радіусі

    private bool enemyInRadius; // Індикатор того - чи є ворог у радіусі
    private Coroutine towerAttack; // Короутина атаки вежі

    private void Awake()
    {
        enemiesInRadius = new List<GameObject>();
    }
    private void Start()
    {
        // StartCoroutine(SpawnProjectile());
        towerAttack = null;
    }
    private void FixedUpdate()
    {
        // Якщо вороги у радіусі, то атакуємо їх
        if (enemiesInRadius.Count > 0)
        {
            enemyInRadius = true;
        }
        // Якщо ворогів немає, то не атакуємо
        else
        {
            enemyInRadius = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (enemiesInRadius.Count == 0)
            {
                towerAttack = StartCoroutine(SpawnProjectile());
                enemiesInRadius.Add(other.gameObject);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (enemiesInRadius.Count == 0)
            {
                StopCoroutine(towerAttack);
                enemiesInRadius.Remove(other.gameObject);
            }
        }
    }
    IEnumerator SpawnProjectile()
    {
        while (true)
        {
            if (enemiesInRadius.Count > 0)
            {
                Projectile projectile = Instantiate(
                    projectilePrefab,
                    spawnPoint.transform.position,
                    Quaternion.identity).GetComponent<Projectile>();

                projectile.targetObj = enemiesInRadius[0];
            }
            
            yield return new WaitForSeconds(attackInterval);
        }
    }
}
