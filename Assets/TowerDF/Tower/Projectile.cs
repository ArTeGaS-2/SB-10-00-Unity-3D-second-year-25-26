using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject targetObj; // До кого летить куля
    [SerializeField] private float projectileSpeed = 10.0f; // Швидкість кулі

    public void SetTargetObject(GameObject target) { targetObj = target; }

    private void FixedUpdate()
    {
        // рух до цілі
        transform.position = Vector3.MoveTowards(
            transform.position, // звідки
            targetObj.transform.position, // куди
            projectileSpeed * Time.fixedDeltaTime); // з якою швидкістю

        transform.LookAt(targetObj.transform.position); // дивимось на ціль
    }
}
