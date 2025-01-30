using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject go;
    public SpriteRenderer sr;
    public EnableDisable script;
    public AudioSource audioSource;
    public AudioClip clip;

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
            script.enabled = false; //turn off scripts
            go.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            sr.enabled = true;
            script.enabled = true;
            go.SetActive(true);
        }
        {
            if (Input.GetKey(KeyCode.Space))
            {
                {
                    if (audioSource.isPlaying == false)
                        //audioSource.Play();
                        audioSource.PlayOneShot(clip);
                }
            }
        }
    }
}
