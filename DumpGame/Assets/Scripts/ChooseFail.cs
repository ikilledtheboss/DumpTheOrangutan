using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseFail : MonoBehaviour {

    public GameObject Person, Immigrant;
    public SpriteRenderer DumpSR, ISR;
    public Sprite DumpFail;
    public bool Done;

    // Use this for initialization
    void Start()
    {
        DumpSR = Person.GetComponent<SpriteRenderer>();
        Done = Immigrant.GetComponent<ChooseSuccess>().click;
    }


    // Update is called once per frame
    void OnMouseDown()
    {
        Done = Immigrant.GetComponent<ChooseSuccess>().click;
        if (Done == false)
            DumpSR.sprite = DumpFail;

            
    }
}
