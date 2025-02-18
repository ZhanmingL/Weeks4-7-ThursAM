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

    Vector2 minBound, maxBound; //screen bound's minimum values and maximum values.


    void Start()
    {
        GetBound(); //In the first frame, I directly count and get the Clamp value.
    }

    void Update()
    {
        MovePlayer(); //Move player.

        ClampPosition(); //Don't get out of screen.
    }

    private void MovePlayer() //my function of player moving, keys input.
    {
        //Player's movement.
        Vector2 pos = transform.position;
        pos.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; //Input of "A""D" and two arrow keys control movement of player (horizontally).
        pos.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; //Input of "W""S" and two arrow keys control movement.
        transform.position = pos;
    }

    private void ClampPosition() //It's a function that controls player within the screen.
    { //this Mathf is important because I don't want my player moves out of screen.
        Vector2 clampP = transform.position; //Player's position is being restricted by Clamp.
        clampP.x = Mathf.Clamp(clampP.x, minBound.x,maxBound.x); //x position value's restriction.
        clampP.y = Mathf.Clamp(clampP.y, minBound.y, maxBound.y); //y position value's restriction.
        transform.position = clampP;
    }
    private void GetBound()
    {
        Vector2 min = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)); //I state where the minimum bound's location is.
        Vector2 max = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)); //I also state maximum bound's location. Now, these helpful vectors stop player's position within the screen.
        minBound = new Vector2(min.x, min.y); //Now give these vectoe values back to main one which gonna be used my me.
        maxBound = new Vector2(max.x, max.y);
    }

    public void GenerateBullet() //This function is important because it is controlled by a button, so also make it public.
    {
            //Prefab executing.
            GameObject newBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity); //When click mouseButton, generate a new bullet from Prefab.
            myBullet = newBullet.GetComponent<Bullet>();

            //These codes are giving values when each new prefab(bullet) is generated, because I cannot directly give value in Prefab's Inspector.
            Bullet wantBulletScript = newBullet.GetComponent<Bullet>(); //I want two Vector2 values from Bullet class, that are playerside and enemyside, then I can give them value.
            wantBulletScript.playerSide = transform.position; //Give generated bullet the player's position(generated position as well).
            wantBulletScript.enemySide = enemySide.position; //Give enemy's position.

            mouseDown = true; //The condition of letting bullet's code run.
        
        if (mouseDown == true && myBullet != null) //I make sure that Bullt is exist, then I run it's code.
        {
            myBullet.shoot(); //Run bullet moving function, then it is shot.
        }
    }
}
