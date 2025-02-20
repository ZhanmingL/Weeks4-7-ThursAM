using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5;
    float range = 50;

    public GameObject gameOverPage;

    public GameObject gold;
    public Transform golden;

    public Transform Stone;

    bool run = false;

    void Start()
    {
        gold.SetActive(true);
        gameOverPage.SetActive(false);
    }


    void Update()
    {
        Vector2 move = transform.position;
        move.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        Vector2 cameraPos = Camera.main.WorldToScreenPoint(move);
        Vector2 goldPos = Camera.main.WorldToScreenPoint(golden.position);
        Vector2 stonePos = Camera.main.WorldToScreenPoint(Stone.position);

        if (Input.GetMouseButtonDown(0)) {
            if (cameraPos.x >= goldPos.x - range && cameraPos.x <= goldPos.x + range)
            {
                gold.SetActive(false);
                run = true;
            }
        }

        transform.position = move;

        StoneRun();
        if (cameraPos.x >= stonePos.x - range && cameraPos.x <= stonePos.x + range)
        {
            gameOverPage.SetActive(true);
        }
    }

    void StoneRun()
    {
        if (run)
        {
            Stone.position += Vector3.left * Time.deltaTime;
        }
    }
}
