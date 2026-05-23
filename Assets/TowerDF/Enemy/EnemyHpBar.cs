using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpBar : MonoBehaviour
{
    private EnemyAgent enemy;
    private Slider hpBar; 
    private void Start()
    {
        enemy = GetComponentInParent<EnemyAgent>();
        hpBar = GetComponent<Slider>();

        hpBar.maxValue = enemy.maxHealth;
        enemy.currentHealth = enemy.maxHealth;
    }
    private void FixedUpdate()
    { 
        transform.LookAt(Camera.main.transform.position);
    }
    public void UpdateEnemyHpBar()
    {
        hpBar.value = enemy.currentHealth;
    }
}