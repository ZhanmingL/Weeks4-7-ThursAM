using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float speed = 5f; //Player sprite's move speed value.


    void Start()
    {
        
    }

    void Update()
    {
        Vector2 move = transform.position;
        move.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; //Input of "A""D" and two arrow keys control movement of player (horizontally).
        transform.position = move;
    }
}
