using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Covfefe1Click : MonoBehaviour {

    public GameObject Covfefe1, Phone;
    public SpriteRenderer CovfefeSR;
    public bool Clicked;
    public Sprite CofevfeClicked;
    public int Rvalue;

    void Start ()
    {
        Clicked = false;
        CovfefeSR = Covfefe1.GetComponent<SpriteRenderer>();
        Rvalue = Random.Range(1, 3);
    }
	
    void Update()
    {
        switch (Rvalue)
        {
            case (0):
                transform.position = new Vector3(-10f, -3.6f, 0.2f);
                break;
            case (1):
                transform.position = new Vector3(10f, -1.0f, 0.2f);
                break;
            case (2):
                transform.position = new Vector3(0f, 5.0f, 0.2f);
                break;
            default:
                break;
        }
    }

	void OnMouseDown()
    {
        CovfefeSR.sprite = CofevfeClicked;
        Clicked = true;	
	}
}
