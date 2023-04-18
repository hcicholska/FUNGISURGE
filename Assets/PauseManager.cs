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

public class ResumeButton : MonoBehaviour
{
    public Button resumeButton;
    public PauseManager pauseManager;
  
        // Przypisujemy funkcję "ResumeGame" do zdarzenia "OnClick" przycisku
        resumeButton.onClick.AddListener ResumeGame;
   
}

}
