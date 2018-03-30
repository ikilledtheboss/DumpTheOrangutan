using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSuccess : MonoBehaviour {


    public GameObject Person;
    public SpriteRenderer DumpSR;
    public Sprite DumpWIn;
    public bool click;

    // Use this for initialization
    void Start()
    {
        DumpSR = Person.GetComponent<SpriteRenderer>();
        click = false;
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        DumpSR.sprite = DumpWIn;
        click = true;
    }
}
