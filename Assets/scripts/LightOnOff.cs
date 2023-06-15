using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public Light lightSource;

    private IEnumerator Start()
    {
        while (true)
        {
            // Wyłącz światło
            lightSource.enabled = false;
            yield return new WaitForSeconds(2f);

            // Włącz światło
            lightSource.enabled = true;
            yield return new WaitForSeconds(2f);
        }
    }
}
