using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveUI : MonoBehaviour
{
    float movE = 5;
    public GameObject randomSprite;
    // Start is called before the first frame update
    void Start()
    {
        randomSprite.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = transform.position;
        move.x += Input.GetAxisRaw("Horizontal") * movE * Time.deltaTime;
        move.y += Input.GetAxisRaw("Vertical") * movE * Time.deltaTime;
        transform.position = move;

        if(move.x >= 4 && move.x <= 8 && move.y >= -2 && move.y <= 2)
        {
            randomSprite.SetActive(true);
        }
        else
        {
            randomSprite.SetActive(false);
        }    
    }

}
