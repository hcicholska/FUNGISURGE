using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinningUi : MonoBehaviour

{
    public GameObject Boss;
    public GameObject YouWonUI;

    void Update()
    {
        // Sprawdzenie, czy hp obiektu o nazwie i tagu Boss wynosi 0
        if (Boss.GetComponent<EnemyScript>().health == 0)
        {
            StartCoroutine(ActivateYouWonUI());
        }
        else
        {
            YouWonUI.SetActive(false);  // Dezaktywacja YouWonUI, jeśli hp nie wynosi 0
        }
    }

    IEnumerator ActivateYouWonUI()
    {
        YouWonUI.SetActive(true);  // Aktywacja YouWonUI
        yield return new WaitForSeconds(5f);  // Oczekiwanie przez 5 sekund
        YouWonUI.SetActive(false);  // Dezaktywacja YouWonUI
    }
}

