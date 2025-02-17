using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHealth = 10f;
    public Slider bar;

    void Start()
    {
        bar.minValue = 0;
        bar.maxValue = 100;
        bar.value = enemyHealth;
    }

    void Update()
    {
        
    }

    public void Damage(float damage)
    {
        enemyHealth -= damage;
        bar.value = enemyHealth;
    }
}
