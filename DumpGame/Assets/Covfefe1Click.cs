using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Covfefe1Click : MonoBehaviour {

    public GameObject Covfefe1;
    public SpriteRenderer CovfefeSR;
    public bool Clicked;
    public Sprite CofevfeClicked;
    
	void Start ()
    {
        Clicked = false;
        CovfefeSR = Covfefe1.GetComponent<SpriteRenderer>();
	}
	
	void OnMouseDown()
    {
        CovfefeSR.sprite = CofevfeClicked;
        Clicked = true;	
	}
}
