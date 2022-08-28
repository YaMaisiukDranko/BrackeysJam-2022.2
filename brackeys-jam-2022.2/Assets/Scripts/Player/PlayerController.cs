using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerHealth PlayerHealth;
    public GameObject particle;
    public GameObject GameOverPanel;

    private void Update()
    {
        PlayerHealth = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
        GameOver();
    }

    public void GameOver()
    {
        if (PlayerHealth.currentHealth <= 0)
        {
            particle.SetActive(true);
            StartCoroutine(delay(1));
        }
    }
    
    private IEnumerator delay(float duration)
    {
        GameOverPanel.SetActive(false);
        yield return new WaitForSeconds(duration);
        GameOverPanel.SetActive(true);
    }
}
