using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("You just quit the game");
    }
    
    public class BackToMenu : MonoBehaviour
    {
        public void GoBack()
        {
            SceneManager.LoadScene(0);
        }
    }
}