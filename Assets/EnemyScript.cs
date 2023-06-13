using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public int health = 100;
    public float hitDuration = 0.5f;
    private Color originalColor;
    private Renderer renderer;
    public AudioSource snailSound;

    void Start() {
        renderer = GetComponentInChildren<Renderer>();
        originalColor = renderer.material.color;
    }

    public void OnMouseDown()
    {
        snailSound.Play();
        health -= 10;
        if (health <= 0) {
            Destroy(gameObject);
        }
        StartCoroutine(HitEffect());
    }



    IEnumerator HitEffect() {
        renderer.material.color = Color.red;
        yield return new WaitForSeconds(hitDuration);
        renderer.material.color = originalColor;
    }
}