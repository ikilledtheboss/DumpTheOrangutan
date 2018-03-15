using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Covfefe3Click : MonoBehaviour
{

    public GameObject Covfefe3, Phone;
    public SpriteRenderer CovfefeSR;
    public bool Clicked;
    public Sprite CofevfeClicked;
    public int Rvalue;

    void Start()
    {
        Clicked = false;
        CovfefeSR = Covfefe3.GetComponent<SpriteRenderer>();
        Rvalue = Random.Range(1, 3);
    }

    void update()
    {
        switch (Rvalue)
        {
            case (0):
                transform.position = new Vector3(10.25f, 3.51f, 0.2f);
                break;
            case (1):
                transform.position = new Vector3(-10.74f, 0f, 0.2f);
                break;
            case (2):
                transform.position = new Vector3(-11.16f, -5.4f, 0.2f);
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
