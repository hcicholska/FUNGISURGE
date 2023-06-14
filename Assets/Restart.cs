using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public Button restartButton; // referencja do przycisku Restart w interfejsie użytkownika
    public PauseManager pauseManager; // referencja do skryptu PauseManager
    public GameObject pauseMenu;

    void Start()
    {
        restartButton.onClick.AddListener(RestartGame); // Dodanie listenera do przycisku restart
    }

    void RestartGame()
    {
        pauseManager.ResumeGame();

        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false);
        }
        SceneManager.LoadScene("Main Game");
    }
}