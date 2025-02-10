using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownInclass : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public SpriteRenderer mySprite;
    public Sprite newItemSprite;

    private void Start()
    {
        mySprite.sprite = dropdown.options[0].image;
    }

    public void OnValueChanged(int index)
    {
        Debug.Log(dropdown.options[index].text);
        mySprite.sprite = dropdown.options[index].image;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TMP_Dropdown.OptionData item = new TMP_Dropdown.OptionData("New Thing!", newItemSprite);
            dropdown.options.Add(item);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (dropdown.options.Count > 0)
            {
                dropdown.options.RemoveAt(dropdown.options.Count - 1);
            }
        }
    }
}
