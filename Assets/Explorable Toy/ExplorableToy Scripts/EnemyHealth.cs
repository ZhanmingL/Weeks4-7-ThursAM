using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    public GameObject gameWinPage;
    public TextMeshProUGUI health;
    public Slider bar;

    public float enemyHealth = 10f;
    public float healthValue = 100f;

    void Start()
    {
        bar.minValue = 0;
        bar.maxValue = 100;
        bar.value = enemyHealth;

        gameWinPage.SetActive(false);
        health.text = healthValue.ToString();
    }

    void Update()
    {
        if(enemyHealth == 0)
        {
            gameWinPage.SetActive(true);
        }
    }

    public void Damage(float damage)
    {
        enemyHealth -= damage;
        bar.value = enemyHealth;
        healthValue -= damage;
        health.text = healthValue.ToString();
    }
}
