using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHome : MonoBehaviour {

    public GameObject Person1, Person2, Immigrant, Door, Curtain, ScoreKeeper, Opened, Dump;
    public SpriteRenderer Person1SR, Person2SR, ImmigrantSR, DoorSR, OpenedSR, DumpSR;
    public Sprite P1, P2, I, D;
    public int Win;
    public bool Clicked;
    public float T;
    public string StageScene;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;

    void Start()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        StageScene = "StageScene";
        Win = 0;
        Person1SR = Person1.GetComponent<SpriteRenderer>();
        Person2SR = Person2.GetComponent<SpriteRenderer>();
        DoorSR = Door.GetComponent<SpriteRenderer>();
        DoorSR.enabled = true;
        ImmigrantSR = Immigrant.GetComponent<SpriteRenderer>();
        Clicked = Immigrant.GetComponent<ClickItem>().Clicked;
        OpenedSR = Opened.GetComponent<SpriteRenderer>();
        OpenedSR.enabled = false;
        DumpSR = Dump.GetComponent<SpriteRenderer>();
        DumpSR.enabled = false;
        T = PlayerPrefs.GetFloat("PTime");
        Curtain.GetComponent<UpFlag>().enabled = true;
        tt = T;
    }

	void Update ()
    {
        Clicked = Immigrant.GetComponent<ClickItem>().Clicked;
        if (Clicked == true)
        {
            OpenedSR.enabled = true;
            DumpSR.enabled = true;
            Person1SR.sprite = P1;
            Person2SR.sprite = P2;
            ImmigrantSR.sprite = I;
            DoorSR.enabled = false;
            Win = 1;
        }

        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Curtain.GetComponent<DownFlag>().enabled = true;
            Curtain.GetComponent<PresentResults>().enabled = true;
            Door.GetComponent<GameHome>().enabled = false;
        }
        else
        {
            T = T - Time.deltaTime;
        }
    }
}
