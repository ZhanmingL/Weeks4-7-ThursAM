using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject go;
    public SpriteRenderer sr;
    public EnableDisable script;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sr.enabled = false;
            //script.enabled = false;
            go.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            sr.enabled = true;
            //script.enabled = true;
            go.SetActive(true);
        }
    }
}
