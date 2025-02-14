using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float speed = 5f; //Player sprite's move speed value.

    public GameObject bulletPrefab; //I want bullet generated from original prefab.

    bool mouseDown = false;

    public Transform enemySide; //Enemy's position, I will get it in Unity's inspector.

    Bullet myBullet; //Get a bullet reference.
    void Start()
    {

    }

    void Update()
    {
        //Player's movement.
        Vector2 pos = transform.position;
        pos.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; //Input of "A""D" and two arrow keys control movement of player (horizontally).
        transform.position = pos;

        //Prefab executing.
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity); //When click mouseButton, generate a new bullet from Prefab.
            myBullet = newBullet.GetComponent<Bullet>();

            //These codes are giving values when each new prefab(bullet) is generated, because I cannot directly give value in Prefab's Inspector.
            Bullet wantBulletScript = newBullet.GetComponent<Bullet>(); //I want two Vector2 values from Bullet class, that are playerside and enemyside, then I can give them value.
            wantBulletScript.playerSide = transform.position; //Give generated bullet the player's position(generated position as well).
            wantBulletScript.enemySide = enemySide.position; //Give enemy's position.

            mouseDown = true; //The condition of letting bullet's code run.
        }
        if (mouseDown == true && myBullet != null) //I make sure that Bullt is exist, then I run it's code.
        {
            myBullet.shoot(); //Run bullet moving function, then it is shot.
        }
    }
}
