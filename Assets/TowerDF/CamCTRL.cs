using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCTRL : MonoBehaviour
{
    [Header("Швидкість")]
    [SerializeField] float moveSpeed = 10f; // швидкість руху
    [SerializeField] float zoomSpeed = 10f; // швидкість зуму

    [Header("Ліміти")]
    [SerializeField] float minZoomDistance = 30f; // Мін відстань
    [SerializeField] float maxZoomDistance = 120f; // Макс відстань

    private void FixedUpdate()
    {
        MoveCamera();
        ZoomCamera();
    }
    private void MoveCamera()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position = new Vector3(
            transform.position.x + horizontal * moveSpeed * Time.fixedDeltaTime,
            transform.position.y,
            transform.position.z + vertical * moveSpeed * Time.fixedDeltaTime);
    }
    private void ZoomCamera()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
    }
}
