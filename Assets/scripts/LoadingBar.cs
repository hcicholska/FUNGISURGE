using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingBar : MonoBehaviour
{
    public Slider slider;
    public Button playButton;
    public Button howtoplayButton;
    public Button optionsButton;
    public Button quitButton;

    private void Start()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
    }

    public void OnPlayButtonClicked()
    {
        
        playButton.gameObject.SetActive(false);
        howtoplayButton.gameObject.SetActive(false);
        optionsButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);
        slider.gameObject.SetActive(true);

        
        StartCoroutine(LoadMainGame());
    }

    private IEnumerator LoadMainGame()
    {
        
        float elapsedTime = 0f;
        float targetTime = Random.Range(1.5f, 2f);
        while (elapsedTime < targetTime)
        {
            elapsedTime += Time.deltaTime;
            float progress = elapsedTime / targetTime;
            slider.value = progress;

            yield return null;
        }
        
        
        SceneManager.LoadScene("Main Game");
    }
}