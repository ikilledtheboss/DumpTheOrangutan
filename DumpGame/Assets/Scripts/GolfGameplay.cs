using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GolfGameplay : MonoBehaviour
{
    public bool clicked;
    public int Win;
    public GameObject Goal, Golfer, Meter, Curtain1, Curtain2, ScoreKeeper;
    public SpriteRenderer MeterSR, GolferSR, GoalSR;
    public Sprite Meter1, Meter2, Player1, Player2, Hole1, Hole2;
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
        clicked = false;
        Win = 0;
        MeterSR = Meter.GetComponent<SpriteRenderer>();
        GolferSR = Golfer.GetComponent<SpriteRenderer>();
        GoalSR = Goal.GetComponent<SpriteRenderer>();
        T = PlayerPrefs.GetFloat("PTime");
        Curtain1.GetComponent<UpFlag>().enabled = true;
        tt = T;
    }
    
    void Update()
    {
        if(clicked == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                clicked = true;
                //Success case
                if (MeterSR.sprite == Meter1)
                {
                    Win = 1;
                    GolferSR.sprite = Player1;
                    GoalSR.sprite = Hole1;

                }
                else if (MeterSR.sprite == Meter2)
                {
                    Win = 0;
                    GolferSR.sprite = Player2;
                    GoalSR.sprite = Hole2;
                }
            }
        }


        if (T< 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Curtain1.GetComponent<DownFlag>().enabled = true;
            Curtain1.GetComponent<PresentResults>().enabled = true;
            Golfer.GetComponent<GolfGameplay>().enabled = false;
        }

        else
        {
            T = T - Time.deltaTime;

            if (clicked == false)
            {
                if ((T % 2) < 1)
                    MeterSR.sprite = Meter2;
                else
                    MeterSR.sprite = Meter1;
            }
        }   
    }
}
