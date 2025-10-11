using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    public GameObject scenePartPrefab; // ������� �����
    public float scenePartStep; // ���� �� �������� �� ������
    public float basePartPos; // ������� �������� ���������
    public int numOfParts; // ʳ������ ���������
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
