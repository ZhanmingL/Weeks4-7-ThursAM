using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float speed = 8; //Enemy uses cannonball to attack player, this is the speed of cannonball flying.

    void Update()
    {
        Vector2 flying = transform.position;
        flying.x -= speed * Time.deltaTime;
        Vector2 cameraPos = Camera.main.WorldToScreenPoint(flying); //I want it to move in the screen page position, so I can use it in the playerMove script class.
        if(cameraPos.x <= 0 || cameraPos.x >= Screen.width) //Stay in the Screen! Return back when touching screen edges.
        {
            flying.y += (int)Random.Range(-1, 1); //this is for higher challenging, when touching edges, also change y-axis, let player moves.
            speed = speed * -1; //go back.
        }
        transform.position = flying;
    }
}
