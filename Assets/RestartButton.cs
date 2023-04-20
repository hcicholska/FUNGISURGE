using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public GameObject player; // referencja do obiektu gracza
    public Transform respawnPoint; // referencja do punktu respawnu
    public health health; // referencja do komponentu zdrowia gracza
    public Button restartButton; // referencja do przycisku Restart w interfejsie użytkownika

    void Start()
    {
        restartButton.onClick.AddListener(RestartGame); // Dodanie listenera do przycisku restart
    }

    void RestartGame()
    {
        Time.timeScale = 1f;
        player.transform.position = respawnPoint.position; // Przywrócenie gracza do punktu respawnu
        health.healthPoints = 300f; // Przywrócenie punktów zdrowia gracza
    
    }
}

