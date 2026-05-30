using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCTRL : MonoBehaviour
{ 
    [Header("Швидкість")]
    [SerializeField] float moveSpeed = 10f; // швидкість руху
    [SerializeField] float zoomSpeed = 1f; // швидкість зуму

    [Header("Ліміти наближення")]
    [SerializeField] float minZoomDistance = 30f; // Мін відстань
    [SerializeField] float maxZoomDistance = 90f; // Макс відстань

    [Header("Ліміти переміщення")]
    [SerializeField] float horizontalLimit = 50f; // Ліміт по горизонталі
    [SerializeField] float verticalLimit = 50f; // Ліміт по вертикалі

    private Vector3 initialPosition; // Початкова позиція камери
    private Vector3 positionLimits; // Ліміти позиції камери

    private void Start()
    {
        // Зберігаємо початкову позицію камери
        initialPosition = transform.position;
        // Встановлюємо ліміти позиції камери
        positionLimits = new Vector3(
            horizontalLimit,       // Ліміт по горизонталі
            transform.position.y,  // Ліміт по вертикалі (залишаємо поточну висоту)
            verticalLimit);        // Ліміт вперед/назад
    }

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

        transform.position = new Vector3(
            Mathf.Clamp(
                transform.position.x,
                initialPosition.x - positionLimits.x,
                initialPosition.x + positionLimits.x),

            transform.position.y,

            Mathf.Clamp(
                transform.position.z,
                initialPosition.z - positionLimits.z,
                initialPosition.z + positionLimits.z));
    }
    private void ZoomCamera()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Camera.main.fieldOfView -= scroll * zoomSpeed * Time.fixedDeltaTime;

        Camera.main.fieldOfView = Mathf.Clamp(
            Camera.main.fieldOfView,
            minZoomDistance,
            maxZoomDistance);
    }
}
