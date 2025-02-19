using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Prefab : MonoBehaviour
{
    public float speed = 5;
    void Update()
    {
        Fly();
    }

    public void Fly ()
    {
        Vector3 rot = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rot.z = 0;
        Vector3 target = rot - transform.position;
        transform.up = target;

        transform.position += transform.up.normalized * speed * Time.deltaTime;
    }
}
