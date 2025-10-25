using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    [Header("Об'єкти")]
    public GameObject basePartPrefab; // Базовий сегмент сцени
    public List<GameObject> anotherParts =
        new List<GameObject>(); // Список інакших сегментів

    [Header("Налаштування")]
    public float scenePartStep; // Крок від сегменту до іншого
    public float basePartPos; // Позиція базового фрагменту
    public int numOfParts; // Кількість фрагментів

   
    private void Awake()
    {
        for (int i = 1; i <= numOfParts; i++)
        {
            if (i == 3 || i == 4 || i == 5)
            {
                Instantiate(anotherParts[0],
                    new Vector3(0, 0,
                    basePartPos + i * scenePartStep),
                    Quaternion.identity);
            }
            else
            {
                Instantiate(basePartPrefab,
                    new Vector3(0, 0,
                    basePartPos + i * scenePartStep),
                    Quaternion.identity);
            }
        }
    }

}
