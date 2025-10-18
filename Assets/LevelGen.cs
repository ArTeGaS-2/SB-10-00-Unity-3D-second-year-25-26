using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    [Header("��'����")]
    public GameObject basePartPrefab; // ������� ������� �����
    public List<GameObject> anotherParts =
        new List<GameObject>(); // ������ ������� ��������

    [Header("������������")]
    public float scenePartStep; // ���� �� �������� �� ������
    public float basePartPos; // ������� �������� ���������
    public int numOfParts; // ʳ������ ���������
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
