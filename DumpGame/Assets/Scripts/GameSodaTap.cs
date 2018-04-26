using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSodaTap : MonoBehaviour {

    public GameObject Self;
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
        if (T < 3)
            Chug = 1.00f;
        else if (T < 4)
            Chug = 0.50f;
        
        tt = T;

        InHold = false;
    }
    
    void Update ()
    {

        if (Progress != 0)
        {
            if (Chug >= 2.0f)
            {
                Self.GetComponent<SpriteRenderer>().sprite = D5;
                Win = 1;
                Progress = 0;
            }
            else if (Chug >= 1.6f)
                Self.GetComponent<SpriteRenderer>().sprite = D4;
            else if (Chug >= 1.2f)
                Self.GetComponent<SpriteRenderer>().sprite = D3;
            else if (Chug >= 0.8f)
                Self.GetComponent<SpriteRenderer>().sprite = D2;
            else if (Chug >= 0.4f)
                Self.GetComponent<SpriteRenderer>().sprite = D0;
            else if (Chug > 0.0f)
                Self.GetComponent<SpriteRenderer>().sprite = D8;
        }
        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Self.GetComponent<PresentResults>().enabled = true;
            Self.GetComponent<GameSodaTap>().enabled = false;
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
                Self.GetComponent<SpriteRenderer>().sprite = D7;
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
