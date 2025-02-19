using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class TankMove : MonoBehaviour
{
    public float speed = 5f;
    public Slider slider;

    void Start()
    {
        
    }


    void Update()
    {
        UpdateSpeed();
        Vector2 move = transform.position;
        move.x += Input.GetAxisRaw("Horizontal")*speed*Time.deltaTime;
        transform.position = move;
    }

    private void UpdateSpeed()
    {
        speed = slider.value;
    }
}
