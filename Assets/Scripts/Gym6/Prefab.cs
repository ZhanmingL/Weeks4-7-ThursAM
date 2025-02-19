using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class Prefab : MonoBehaviour
{
    public float speed = 5;
    Vector3 direction;
    private void Start()
    {
        Vector3 rot = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rot.z = 0;
        direction = rot - transform.position;
        transform.up = direction;
    }

    void Update()
    {
        Fly();
    }

    public void Fly ()
    {
        

        transform.position += transform.up.normalized * speed * Time.deltaTime;
    }
}
