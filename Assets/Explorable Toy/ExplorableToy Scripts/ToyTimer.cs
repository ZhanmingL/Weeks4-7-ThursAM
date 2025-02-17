using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToyTimer : MonoBehaviour
{
    public Slider timer; //use slider to make my game's timer.

    public float maxTime = 30f; //maximum value of my slider is 100.

    void Start()
    {
        timer.value = maxTime; //initialize timer value to the maximum.
    }


    void Update()
    {
        timer.value -= Time.deltaTime; //timer's value is decreasing everyframe.
    }
}
