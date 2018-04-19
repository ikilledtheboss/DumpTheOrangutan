using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSodaTap : MonoBehaviour {

    public GameObject Drink, Curtain, ScoreKeeper;
    public SpriteRenderer Drinksr;
    public Sprite D0, D2, D3, D4, D5, D6, D7, D8;
    public int Progress, Win;
    public float T, Chug;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt, Track;
    public bool InHold;

    void Start()
    {
     //   Track = 0;
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

        Curtain.GetComponent<UpFlag>().enabled = true;
        tt = T;

        InHold = false;
    }
    
    void Update ()
    {

        if (Progress != 0)
        {
            if (Chug >= 2.0f)
            {
                Drinksr.sprite = D5;
                Win = 1;
                Progress = 0;
            }
            else if (Chug >= 1.6f)
                Drinksr.sprite = D4;
            else if (Chug >= 1.2f)
                Drinksr.sprite = D3;
            else if (Chug >= 0.8f)
                Drinksr.sprite = D2;
            else if (Chug >= 0.4f)
                Drinksr.sprite = D0;
            else if (Chug > 0.0f)
                Drinksr.sprite = D8;
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
            {
                Chug = Chug + Time.deltaTime;
                //if (Track >= 0)
                //{
                //    Track = Track - Time.deltaTime;
                //    Drinksr.sprite = D8;
                //}
            }
            else if (Progress != 0 && Chug > 0) 
            {
                Drinksr.sprite = D7;
            }
        }
    }

    void OnMouseDown()
    {
        InHold = true;
       // Track = Chug + .2;
    }

    void OnMouseUp()
    {
        InHold = false;
    //    Track = 0;
    }
}
