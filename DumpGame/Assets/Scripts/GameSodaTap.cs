using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSodaTap : MonoBehaviour {

    public GameObject Drink, Curtain, ScoreKeeper;
    public SpriteRenderer Drinksr;
    public Sprite D2, D3, D4;
    public int Progress, Win, Dragged;
    public float T, Chug;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;
    public bool InHold;

    void Start()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Progress = 1;
        Win = 0;
        T = PlayerPrefs.GetFloat("PTime");
        Chug = 0;
        Drinksr = Drink.GetComponent<SpriteRenderer>();
        if (T < 3)
            Chug = 1.00f;
        else if (T < 4)
            Chug = 0.50f;

        Dragged = Drink.GetComponent<ClickDragItem>().Drag;
        Curtain.GetComponent<UpFlag>().enabled = true;
        tt = T;

        InHold = false;
    }
    
    void Update ()
    {
        if (Progress != 0)
        {
            if (Chug >= 1.8f)
            {
                Drinksr.sprite = D4;
                Win = 1;
                Progress = 0;
            }
            else if (Chug >= 1.2f)
                Drinksr.sprite = D3;
            else if (Chug >= 0.6f)
                Drinksr.sprite = D2;
        }
        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Curtain.GetComponent<DownFlag>().enabled = true;
            Curtain.GetComponent<PresentResults>().enabled = true;
            Drink.GetComponent<GameSodaTap>().enabled = false;
        }

        else
        {
            T = T - Time.deltaTime;
            if (InHold == true)
                Chug = Chug + Time.deltaTime;
        }
    }

    void OnMouseDown()
    {
        InHold = true;
    }

    void OnMouseUp()
    {
        InHold = false;
    }
}
