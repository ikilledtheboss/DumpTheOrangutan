using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Covfefe2Click : MonoBehaviour
{

    public GameObject Covfefe2;
    public SpriteRenderer CovfefeSR2;
    public bool Clicked;
    public Sprite CofevfeClicked;

    void Start()
    {
        Clicked = false;
        CovfefeSR2 = Covfefe2.GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        CovfefeSR2.sprite = CofevfeClicked;
        Clicked = true;
    }
}
