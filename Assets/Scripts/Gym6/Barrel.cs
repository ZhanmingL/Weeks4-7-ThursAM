using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 rot = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rot.z = 0;
        Vector3 target = rot - transform.position;
        //float degree = Mathf.Atan2(rot.x, rot.y);
        //transform.rotation = Quaternion.Euler(new Vector3(0, 0, -degree * 50));
        transform.up = target;

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
    private void Fire()
    {
        GameObject bullet = Instantiate(prefab);
        Destroy(bullet, 3);
    }
}
