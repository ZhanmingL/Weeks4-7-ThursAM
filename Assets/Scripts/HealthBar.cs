using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float health = 10;
    public Slider visuals;
    // Start is called before the first frame update
    void Start()
    {
        visuals.minValue = 0;
        visuals.maxValue = health;
        visuals.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        visuals.value = health;
    }
}