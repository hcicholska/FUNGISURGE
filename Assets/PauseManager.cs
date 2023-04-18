using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPaused;

    void Start()
    {
        // Początkowo ukrywamy menu pauzy
        pauseMenu.SetActive(false);
        isPaused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        // Twój kod do wznowienia gry
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        isPaused = false;
    }

    public void PauseGame()
    {
        // Twój kod do zatrzymania gry
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        isPaused = true;
    }
}

public class ResumeButton : MonoBehaviour
{
    public Button resumeButton;
    public PauseManager pauseManager;

    void Start()
    {
        // Przypisujemy funkcję "ResumeGame" do zdarzenia "OnClick" przycisku
        resumeButton.onClick.AddListener(Resume);
    }

    void Resume()
    {
        // Wywołujemy metodę "ResumeGame" na obiekcie klasy "PauseManager"
        pauseManager.ResumeGame();
    }
}
