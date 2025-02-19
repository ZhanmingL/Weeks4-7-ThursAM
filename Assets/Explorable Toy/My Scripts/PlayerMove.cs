using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//I have so many codes in this script, so I divide them into many useful functions, I hope you will check them clearer as well.

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f; //Player sprite's move speed value.
    public float healthValue = 10f; //Player has 10 health values in maximum.
    public float enemyDamage = 6; //When player touches enemy, the value of losing health.

    public GameObject bulletPrefab; //I want bullet generated from original prefab.
    public GameObject gameOverPage; //I want this UI image comeout when player's health == 0.

    //bool mouseDown = false; //condition of click mouse, and shoot one bullet.
    bool buttonDown = false; //Now I want to use button to determine a button shoot, so this is new name of my bool.

    public Transform enemySide; //Enemy's position, I will get it in Unity's inspector.
    public Transform enemyAttacker; //get the transformposition value to get damage.

    Bullet myBullet; //Get a bullet reference.

    public Slider playerHealth; //Player's health bar, not interactable.


    void Start()
    {
        playerHealth.minValue = 0;
        playerHealth.maxValue = healthValue; //when player's health is full.
        playerHealth.value = healthValue; //at the beginning of my toy game, set player's health bar to full.

        gameOverPage.SetActive(false); //I do not want this page on at the beginning.
    }

    void Update()
    {
        MovePlayer(); //Move player, and calculate damage from cannonball.

        GameOverPage(); //Open game over screen when player is dead.
    }

    private void MovePlayer() //my function of player moving, keys input.
    {
        //Player's movement.
        Vector2 pos = transform.position;
        pos.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; //Input of "A""D" and two arrow keys control movement of player (horizontally).
        pos.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; //Input of "W""S" and two arrow keys control movement.
        transform.position = pos;

        Vector2 enemyMove = enemyAttacker.position; //get enemy's position.
        if ((enemyMove.x <= pos.x + 2.5 && enemyMove.x >= pos.x - 2.5) && (enemyMove.y <= pos.y + 1 && enemyMove.y >= pos.y - 1)) //Calculation of player's position within enemy's position, so I can do health damage.
        {
            playerHealth.value -= enemyDamage * Time.deltaTime; //Lose health when player's position is in the enemyAttacker's position, enemyAttacker is like a big cannonball.
        }
    }

    public void GenerateBullet() //This function is important because it is controlled by a button, so also make it public. Others are not matter, so I make them private.
    {
        //Prefab executing.
        GameObject newBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity); //When click mouseButton, generate a new bullet from Prefab.
        myBullet = newBullet.GetComponent<Bullet>(); //I also want to get a function, use newBullet to get from Bullet, then myBullet is OK to get access.

        //These codes are giving values when each new prefab(bullet) is generated, because I cannot directly give value in Prefab's Inspector.
        //I want two Vector2 values from Bullet class script, that are playerside and enemyside, then I can give them value.
        myBullet.playerSide = transform.position; //Give generated bullet the player's position(generated position as well).
        myBullet.enemySide = enemySide.position; //Give enemy's position.

        buttonDown = true; //Accept bullet's code run.
        
        if (buttonDown == true && myBullet != null) //I make sure that Bullt is exist, then I run it's code.
        {
            myBullet.shoot(); //Run bullet moving function, then it is shot.
        }
    }

    private void GameOverPage()
    {
        if(playerHealth.value == 0) //When player lose all the health,
        {
            gameOverPage.SetActive(true); // then game over.
        }
    }
}
