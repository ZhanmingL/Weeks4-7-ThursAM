using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletPrefab; //I want bullet generated from original prefab.


    [Range(0, 1)]
    public float t; //Moving time range.

    public Transform playerSide; //Shooting position (Player's position).
    public Transform enemySide; //Enymy's position, check arrival.

    void Start()
    {
        
    }


    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(bulletPrefab, playerSide.position, Quaternion.identity); //When click mouseButton, generate a new bullet from Prefab.

            transform.position = Vector2.Lerp(playerSide.position, enemySide.position, t); //Use Lerp to move bullet from player to enemy.

            if (t < 1)
            {
                t += Time.deltaTime; //add t value from 0 to 1.
            }
            else
            {
                Destroy(newBullet); //When getting 1, also means bullet get enemy's position, destroy bullet.
            }
        }
    }
}
