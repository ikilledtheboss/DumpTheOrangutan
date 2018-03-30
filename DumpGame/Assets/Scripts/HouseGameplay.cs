using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HouseGameplay : MonoBehaviour
{
    public GameObject Person1, Person2, Immigrant, Dump, Curtain, ScoreKeeper;
    public SpriteRenderer Person1SR, Person2SR, ImmigrantSR, DumpSR;
    public Sprite P1, P2, I, D;
    public int Win;
    public bool Clicked;
    public float T;
    public string StageScene;

    // Use this for initialization
    void Start ()
    {
        StageScene = "StageScene";
        Win = 0;
        Person1SR = Person1.GetComponent<SpriteRenderer>();
        DumpSR = Dump.GetComponent<SpriteRenderer>();
        Person2SR = Person2.GetComponent<SpriteRenderer>();
        ImmigrantSR = Immigrant.GetComponent<SpriteRenderer>();
        Clicked = Immigrant.GetComponent<ChooseSuccess>().click;
        T = PlayerPrefs.GetFloat("PTime");
        Curtain.GetComponent<UpFlag>().enabled = true;
    }


    // Update is called once per frame
    void Update ()
    {
        Clicked = Immigrant.GetComponent<ChooseSuccess>().click;
        if (Clicked == true)
        {
            Person1SR.sprite = P1;
            Person2SR.sprite = P2;
            ImmigrantSR.sprite = I;
            DumpSR.sprite = D;
            Win = 1;
        }

        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            SceneManager.LoadScene(StageScene);
        }
        else
        {
            T = T - Time.deltaTime;
        }
    }
}
