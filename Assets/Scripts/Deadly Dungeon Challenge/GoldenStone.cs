using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenStone : MonoBehaviour
{
    public float yStrength = 0.5f;
    public float speed = 0.5f;
    float yStart;
    float yChange;


    void Start()
    {
        yStart = transform.position.y;
        yChange = Random.Range(0, 100);
    }

    // Update is called once per frame
    void Update()
    {
        float newY = yStart + Mathf.PerlinNoise(speed * Time.time, yChange) * yStrength - (yStrength/2);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
