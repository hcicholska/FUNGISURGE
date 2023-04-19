using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    public GameObject player; // referencja do obiektu gracza
    public Transform respawnPoint; // referencja do punktu respawnu
    public health playerHealth; // referencja do komponentu zdrowia gracza
    public Button restartButton; // referencja do przycisku Restart w interfejsie użytkownika

    void Start()
    {
        // Dodanie listenera do przycisku restart
        restartButton.onClick.AddListener(RestartGame);
    }

    // Metoda wywołana po kliknięciu przycisku Restart
    void RestartGame()
    {
        // Przywrócenie gracza do punktu respawnu
        player.transform.position = respawnPoint.position;

        // Przywrócenie punktów zdrowia gracza
        playerHealth.healthPoints = 300f;

      
    }
}

