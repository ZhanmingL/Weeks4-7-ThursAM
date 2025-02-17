using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {

    }

    void Update()
    {
        Vector2 move = transform.position;
        move.x += speed * Time.deltaTime;
        Vector2 camera = Camera.main.WorldToScreenPoint(move);
        if (camera.x < -10 || camera.x > Screen.width)
        {
            speed = speed * -1;
        }
        transform.position = move;
    }
}
