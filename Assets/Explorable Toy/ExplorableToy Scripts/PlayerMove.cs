using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float speed = 5f; //Player sprite's move speed value.

    public GameObject bulletPrefab; //I want bullet generated from original prefab.

    void Start()
    {

    }

    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; //Input of "A""D" and two arrow keys control movement of player (horizontally).
        transform.position = pos;

        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity); //When click mouseButton, generate a new bullet from Prefab.
        }
    }
}
