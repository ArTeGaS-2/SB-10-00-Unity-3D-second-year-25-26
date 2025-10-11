using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    public GameObject scenePartPrefab; // Сегмент сцени
    public float scenePartStep; // Крок від сегменту до іншого
    public float basePartPos; // Позиція базового фрагменту
    public int numOfParts; // Кількість фрагментів
    private void Awake()
    {
        for (int i = 1; i <= numOfParts; i++)
        {
            Instantiate(scenePartPrefab,
                new Vector3(0, 0,
                    basePartPos + i * scenePartStep),
                Quaternion.identity);
        }
    }

}
