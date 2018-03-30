using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickItem : MonoBehaviour
{
    public bool Clicked;

    void Start()
    {
        Clicked = false;
    }

    void OnMouseDown()
    {
        Clicked = true;
    }
}
