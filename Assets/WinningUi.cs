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
       
        if (Boss.GetComponent<EnemyScript>().health == 0)
        {
            StartCoroutine(ActivateYouWonUI());
        }
        else
        {
            YouWonUI.SetActive(false);  
        }
    }

    IEnumerator ActivateYouWonUI()
    {
        YouWonUI.SetActive(true);  
        yield return new WaitForSeconds(5f);  
        YouWonUI.SetActive(false);  
    }
}

