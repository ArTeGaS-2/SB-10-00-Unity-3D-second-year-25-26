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

        }
    }
    private void SetLineObject(int line_num)
    {
        int choose = Random.Range(0, 2); // Рандомне число, визначає вибір

        switch (choose)
        {
            case 0:
                break;
            case 1:
                foreach (GameObject k in listOfCollectables)
                {
                    if (k.activeSelf == false) k.SetActive(true);
                    if (line_1 == 0) k.transform.localPosition = new Vector3(
                        -2.25f,
                        k.transform.localPosition.y,
                        k.transform.localPosition.z);
                    else if (line_2 == 0) k.transform.localPosition = new Vector3(
                        0f,
                        k.transform.localPosition.y,
                        k.transform.localPosition.z);
                    else if (line_3 == 0) k.transform.localPosition = new Vector3(
                        2.25f,
                        k.transform.localPosition.y,
                        k.transform.localPosition.z);
                }
                break;
            case 2:
                foreach (GameObject k in listOfObstacles)
                {
                    if (k.activeSelf == false) k.SetActive(true);
                    if (line_1 == 0) k.transform.localPosition = new Vector3(
                        -2.25f,
                        k.transform.localPosition.y,
                        k.transform.localPosition.z);
                    else if (line_2 == 0) k.transform.localPosition = new Vector3(
                        0f,
                        k.transform.localPosition.y,
                        k.transform.localPosition.z);
                    else if (line_3 == 0) k.transform.localPosition = new Vector3(
                        2.25f,
                        k.transform.localPosition.y,
                        k.transform.localPosition.z);

                }
                break;
        }
    }
}
