using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LooseOrPauseWindow : MonoBehaviour
{
    [Header("Посилання на об'єкти")]
    public GameObject pauseWindow; // Вікно паузи

    private void Start()
    {
        pauseWindow.SetActive(false); // Вимикаємо вікно паузи на початку
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseWindow.activeSelf)
            {
                ResumeGame(); // Якщо вікно паузи відкрите, відновлюємо гру
            }
            else
            {
                PauseGame(); // Якщо вікно паузи закрите, зупиняємо гру
            }
        }
    }
    public void PauseGame()
    {
        Time.timeScale = 0f; // Зупиняємо час
        pauseWindow.SetActive(true); // Відображаємо вікно паузи
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f; // Відновлюємо час
        pauseWindow.SetActive(false); // Ховаємо вікно паузи
    }
    public void RestartGame()
    {
        Time.timeScale = 1f; // Відновлюємо час
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Перезавантажуємо поточну сцену
    }
    public void ExitToMenu()
    {
        Time.timeScale = 1f; // Відновлюємо час
        SceneManager.LoadScene("Menu"); // Завантажуємо сцену меню
    }
}
