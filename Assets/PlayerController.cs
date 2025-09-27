using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int currentLine = 0; // ������� ���
    public float posHorizontalStep = 2.25f; // ����� ������� �� ���������
    private void Update()
    {
        // ���� (��������.��������������(���������.�����������))
        if (Input.GetKeyDown(KeyCode.RightArrow) && currentLine < 1)
        {
            currentLine++; // +1 �� �����
            transform.Translate(Vector3.right * posHorizontalStep);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && currentLine > -1)
        {
            currentLine--; // -1 �� �����
            transform.Translate(Vector3.left * posHorizontalStep);
        }
    }
}
