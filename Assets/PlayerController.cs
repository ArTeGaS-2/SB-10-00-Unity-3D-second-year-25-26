using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int currentLine = 0; // Поточна лінія
    public float posHorizontalStep = 2.25f; // Змінна позиції по горизонту
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
    }
}
