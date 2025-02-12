using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Range(0, 1)]
    public float t = 0; //Moving time range.

    public float speed = 5f;

    public Transform playerSide; //Shooting position (Player's position).
    public Transform enemySide; //Enymy's position, check arrival.

    void Start()
    {
        
    }


    void Update()
    {
            transform.position = Vector2.Lerp(playerSide.position, enemySide.position, t); //Use Lerp to move bullet from player to enemy.

            t += Time.deltaTime * speed; //add t value from 0 to 1.

            if (t == 1)
            {
                Destroy(gameObject); //When getting 1, also means bullet get enemy's position, destroy bullet.
            }
    }
}
