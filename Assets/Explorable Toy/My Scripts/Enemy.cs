using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    public float speed = 10f; //enemy's move speed.

    void Update()
    {
        Vector2 move = transform.position;
        move.x += speed * Time.deltaTime;
        Vector2 camera = Camera.main.WorldToScreenPoint(move); //I want it to stay in the camera's screen, and use camera screen position values to do calculation.
        if (camera.x < -10 || camera.x > Screen.width) //Stay in Screen! I want it go back when touching edges.
        {
            speed = speed * -1; //go back.
        }
        transform.position = move;
    }
}
