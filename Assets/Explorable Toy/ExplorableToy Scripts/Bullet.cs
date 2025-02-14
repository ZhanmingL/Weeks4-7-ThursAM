using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Range(0, 1)]
    public float t = 0f; //Moving time range.
    public float speed = 5f; //Bullet's speed.

    //Initially, I wanted to use public Transform to get positions, but they are not able to be selected in Prefab, so I edited it from Transform to Vector, yeah now is vector2, it works.
    public Vector2 playerSide; //Shooting position (Player's position).
    public Vector2 enemySide; //Enymy's position, check arrival position.

    bool canShoot = false; //This bool statement is super important, I had an issue which is about if I click mouse fastly, many bullets' t values can not be increased,
                           //because I infered that there is only one t that controls all the prefabs, so now I make a bool, and make all prefabs individually, they don't affect each other anymore!

    void Start()
    {
        
    }


    void Update()
    {
        if (canShoot)
        {
            Destroy(gameObject, 1);

            if (t < 1)
            {
                t += Time.deltaTime * speed; //add t value from 0 to 1.
                transform.position = Vector2.Lerp(playerSide, enemySide, t); //Use Lerp to move bullet from player to enemy.
            }
            else
            {
                Destroy(gameObject); //When getting 1, also means bullet get enemy's position, destroy bullet.
            }
        }
    }

    public void shoot()
    {
        canShoot = true; //Be controlled in player's script, let it become true and do shooting.
    }
}
