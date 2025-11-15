using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartController : MonoBehaviour
{
    [Header("Списки об'єктів")]
    public List<GameObject> listOfObstacles; // Перешкоди
    public List<GameObject> listOfCollectables; // Монети

    [Header("Кількість активних")]
    [Range(0, 2)] public int numOfObstacle = 0; // кільк. активних перешкод
    [Range(0, 3)] public int numOfCollectables = 0; // кільк. акт. монет
    private int activeParts = 0; // загальна кількість активних ліній

    private bool line_1, line_2, line_3 = false;



}
