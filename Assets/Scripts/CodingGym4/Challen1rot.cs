using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challen1rot : MonoBehaviour
{
    float fasterSpeed = 10f; //Clock rotates faster than real time.
    float secondDegree;
    float nowAngle = 0f;
    float rotation;
    int hourCalculator = 1; //Count how many hours have nov and been gone.

    void Start()
    {
        
    }


    void Update()
    {
        secondDegree = (360f / 12f) / 60f; //360 degrees devide 12 is 30 degrees which mean 12 hours move a whole circle round, then /60 means how many degrees rotate per second.
        rotation = fasterSpeed * secondDegree * Time.deltaTime;
        nowAngle += rotation;
        transform.Rotate(0f, 0f, -rotation); //Rotating with degrees, clockWise so negative.

        if(nowAngle >= 30f)
        {
            nowAngle -= 30f;
            HourTeller();
        }
    }

    void HourTeller()
    {
        Debug.Log("Now is" + hourCalculator + "O'Clock"); //Report time.
        hourCalculator = (hourCalculator % 12) + 1; //12 hours in total, reset when get max.
    }
}