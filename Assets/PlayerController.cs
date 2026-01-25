using System.Collections;
using System.Collections.Generic;
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
        if (Input.GetKeyDown(KeyCode.RightArrow)
            || Input.GetKeyDown(KeyCode.D)
            && currentLine < 1)
        {
            currentLine++; // +1 до змінної
            transform.Translate(Vector3.right * posHorizontalStep);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)
            || Input.GetKeyDown(KeyCode.A)
            && currentLine > -1)
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
        transform.position = new Vector3(0, 1, -3);
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
