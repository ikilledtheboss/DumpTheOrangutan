using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Covfefe3Click : MonoBehaviour
{

    public GameObject Covfefe3;
    public SpriteRenderer CovfefeSR;
    public bool Clicked;
    public Sprite CofevfeClicked;

    void Start()
    {
        Clicked = false;
        CovfefeSR = Covfefe3.GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        CovfefeSR.sprite = CofevfeClicked;
        Clicked = true;
    }
}
