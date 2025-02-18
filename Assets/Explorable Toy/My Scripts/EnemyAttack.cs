using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 flying = transform.position;
        flying.x -= speed * Time.deltaTime;
        Vector2 cameraPos = Camera.main.WorldToScreenPoint(flying);
        if(cameraPos.x <= 0 || cameraPos.x >= Screen.width)
        {
            flying.y += (int)Random.Range(-1, 1);
            speed = speed * -1;
        }
        transform.position = flying;
    }
}
