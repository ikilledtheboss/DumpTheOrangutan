using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Covfefe2Click : MonoBehaviour
{

    public GameObject Covfefe2, Phone;
    public SpriteRenderer CovfefeSR2;
    public bool Clicked;
    public Sprite CofevfeClicked;
    public int Rvalue;

    void Start()
    {
        Clicked = false;
        CovfefeSR2 = Covfefe2.GetComponent<SpriteRenderer>();
        Rvalue = Random.Range(1, 3);
    }

    void Update()
    {
        switch (Rvalue)
        {
            case (0):
                transform.position = new Vector3(-7.0f, 5f, 0.2f);
                break;
            case (1):
                transform.position = new Vector3(9.50f, 2.64f, 0.2f);
                break;
            case (2):
                transform.position = new Vector3(-7.8f, -3.97f, 0.2f);
                break;
            default:
                break;
        }
    }

    void OnMouseDown()
    {
        CovfefeSR2.sprite = CofevfeClicked;
        Clicked = true;
    }
}
