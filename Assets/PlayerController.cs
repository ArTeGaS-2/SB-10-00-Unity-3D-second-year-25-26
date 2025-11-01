using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int currentLine = 0; // Поточна лінія
    public float posHorizontalStep = 2.25f; // Змінна позиції по горизонту

    private Rigidbody rb;
    private bool isGrounded;
    public float jumpForce = 6f;
    private void Update()
    {
        // Якщо (Введення.ОтриматиКлавішу(КодКлавіші.ПраваСтрілка))
        if (Input.GetKeyDown(KeyCode.RightArrow) && currentLine < 1)
        {
            currentLine++; // +1 до змінної
            transform.Translate(Vector3.right * posHorizontalStep);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && currentLine > -1)
        {
            currentLine--; // -1 до змінної
            transform.Translate(Vector3.left * posHorizontalStep);
        }
        if (isGrounded && Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(1); // 1 - Гра, 0 - Меню
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
