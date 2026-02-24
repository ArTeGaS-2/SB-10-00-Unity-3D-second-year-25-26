using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int currentLine = 0; // ������� ���
    public float posHorizontalStep = 2.25f; // ����� ������� �� ���������

    private Rigidbody rb;
    private bool isGrounded;
    public float jumpForce = 6f;   
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)
            || Input.GetKeyDown(KeyCode.D))
        {
            if (currentLine < 1)
            {
                currentLine++;
                transform.Translate(Vector3.right * posHorizontalStep);
            }
            
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)
            || Input.GetKeyDown(KeyCode.A))
        {
            if (currentLine > -1)
            {
                currentLine--;
                transform.Translate(Vector3.left * posHorizontalStep);
            }
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
