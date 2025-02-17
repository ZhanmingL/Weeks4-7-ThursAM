using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    float speed = 5f;
    float speedSpeed = 5;

    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player's movement.
        Vector2 PlayerPos = Player.position;
        PlayerPos.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime; //Input of "A""D" and two arrow keys control movement of player (horizontally).
        PlayerPos.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime; //Input of "W""S" and two arrow keys control movement.
        Player.position = PlayerPos;

        Vector2 attack = transform.position;
        attack.x -= speedSpeed * Time.deltaTime;
        transform.position = attack;
    }
}
