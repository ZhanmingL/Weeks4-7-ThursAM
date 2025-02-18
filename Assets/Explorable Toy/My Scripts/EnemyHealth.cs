using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    public GameObject gameWinPage; //Game Win Screen.
    public TextMeshProUGUI health; //Enemy has 100 health(hit points), here I want use this text to count health left.
    public Slider bar; //HealthBar of enemy.
    public Slider damageSlider; //A slider that can edit damage value by player.

    public float enemyHealth = 100f; //enemy has 100 health values.
    public float healthValue;
    float damage;

    void Start()
    {
        bar.minValue = 0;
        bar.maxValue = enemyHealth;
        bar.value = enemyHealth; //enemyHealth is the variable for slider bar.

        damageSlider.minValue = 2;
        damageSlider.maxValue = 6;
        damageSlider.value = 2;
        damage = damageSlider.value; //I want the slider value is the lowest at the beginning and also equal to below function's used damage value.

        gameWinPage.SetActive(false); //Keep hiding the gameover-win page at the beginning of the toy game.
        health.text = healthValue.ToString(); //Initialize the number of hit points.
    }

    void Update()
    {
        if(enemyHealth <= 0)
        {
            gameWinPage.SetActive(true); //If enemy's health is below zero, use this UI image to hide game screen, likes the game is over and win.
        }
    }

    public void Damage()
    {
        enemyHealth -= damage;
        bar.value = enemyHealth; //Decrease bar fill.
        healthValue -= damage;
        health.text = healthValue.ToString(); //Decrease hit points number text.
    }
    public void DamageSlider()
    {
        damage = damageSlider.value; //Once I'm using the slider, the damage value also need to changes.
    }
}
