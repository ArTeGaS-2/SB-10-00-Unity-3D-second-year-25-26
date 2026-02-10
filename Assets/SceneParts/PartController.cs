using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartController : MonoBehaviour
{
    [Header("Списки об'єктів")]
    public List<GameObject> listOfObstacles; // Перешкоди
    public List<GameObject> listOfCollectables; // Монети

    [Header("Кількість активних(Не більше 3 загалом)")]
    [Range(0, 2)] public int numOfObstacle = 0; // кільк. активних перешкод
    [Range(0, 3)] public int numOfCollectables = 0; // кільк. акт. монет
    private int activeParts = 0; // загальна кількість активних ліній

    // 0 - пусто, 1 - монета, 2 - перешкода
    private int line_1, line_2, line_3 = 0; 

    private void OnEnable()
    {
        if (line_1 == 0)
        {
            SetLineObject(0);
        }
        if (line_2 == 0)
        {
            SetLineObject(1);
        }
        if (line_3 == 0)
        {
            SetLineObject(2);
        }
    }
    private void SetLineObject(int line_num)
    {
        int choose = Random.Range(0, 3); // Рандомне число, визначає вибір
        float direction = 0f;

        switch (line_num)
        {
            case 0:
                direction = -2.25f;
                break;
            case 1:
                direction = 0f;
                break;
            case 2:
                direction = 2.25f;
                break;
        }
        switch (choose)
        {
            case 0:
                break;
            case 1:
                ChooseObj(listOfCollectables, direction);
                break;
            case 2:
                ChooseObj(listOfObstacles, direction);
                break;
        }
    }
    private void ChooseObj(List<GameObject> objList, float dir)
    {
        foreach (GameObject col in objList)
        {
            if (col.activeSelf == false)
            {
                col.transform.position = new Vector3(
                    dir,
                    col.transform.position.y,
                    col.transform.position.z);
                col.SetActive(true);
                return;
            }
        }
    }
}

