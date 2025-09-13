using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void LoadGameScene() // Завантажує сцену гри
    {
        SceneManager.LoadScene(1); // За індексом 1
    }
    public void LoadMenuScene() // Завантажує сцену меню
    {
        SceneManager.LoadScene(0); // За індексом 0
    }
}
