﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Playables;

public class PresentResults : MonoBehaviour
{
    public GameObject TimeText, StageSetUp, Up, Down;
    public Text ScoreText, LivesText, RuleText;
    public int Score, Lives, Win, rvalue1, rvalue2, rvalue3, rep1, rep2, rep3, rep4, orderrep, orderset;
    public float T, Check1;
    public double timecheck;
    public bool Positive, Finish;
    public string NextGame;
    public PlayableDirector CurtainGood, CurtainBad, Success, Fail;

    // Use this for initialization
    void Start()
    {
        Positive = true;
        StageSetUp.SetActive(true);
        Check1 = 0;
        Finish = false;
        Lives = PlayerPrefs.GetInt("PLives");
        Score = PlayerPrefs.GetInt("PScore");
        Win = PlayerPrefs.GetInt("Result");
        timecheck = -1;

        if (Win == 1)
        {
            Score++;
            PlayerPrefs.SetInt("PScore", Score);
        }
        else if (Win == 0)
        {
            Lives--;
            PlayerPrefs.SetInt("PLives", Lives);
        }

        if(Lives != 3 || Score != 0)
        {
            if (Win == 1)
                Success.Play();
            else
                Fail.Play();
        }

        if (Score == 20)
            Finish = true;
        if (Lives == 0)
        {
            NextGame = "LoseScreen";
            SceneManager.LoadScene(NextGame);
        }

        if (Score >= 15)
        {
            PlayerPrefs.SetInt("CurrentSets", 4);
            PlayerPrefs.SetFloat("PTime", 3.5f);
        }
        else if (Score >= 10)
        { 
            PlayerPrefs.SetInt("CurrentSets", 3);
            PlayerPrefs.SetFloat("PTime", 4.5f);
        }
        else if (Score >= 5)
        {
            PlayerPrefs.SetInt("CurrentSets", 2);
            PlayerPrefs.SetFloat("PTime", 5.5f);
        }

        T = PlayerPrefs.GetFloat("PTime");
        
        if (Finish == true)
        {
            Up.GetComponent<SpriteRenderer>().enabled = true;
            Down.GetComponent<SpriteRenderer>().enabled = false;
            CurtainGood.Play();
            Positive = true;
            NextGame = "VoteGame";
        }

        else if (Lives == 0)
        {
            Up.GetComponent<SpriteRenderer>().enabled = false;
            Down.GetComponent<SpriteRenderer>().enabled = true;
            CurtainBad.Play();
            Positive = false;
            NextGame = "LoseScreen";
        }

        else
        {
            rvalue2 = RandomValue();
            PlayerPrefs.SetInt("CurrentGame", rvalue2);
            if (rvalue2 <= 7)
            {
                Up.GetComponent<SpriteRenderer>().enabled = true;
                Down.GetComponent<SpriteRenderer>().enabled = false;
                CurtainGood.Play();
                Positive = true;
            }
            else
            {
                Up.GetComponent<SpriteRenderer>().enabled = false;
                Down.GetComponent<SpriteRenderer>().enabled = true; 
                CurtainBad.Play();
                Positive = false;
            }
            if (rvalue2 == 0)
            {
                NextGame = "GolfAnimatedGame";
              //  RuleText.text = "DUMP RESORT: TAP at the right moment";
            }
            else if (rvalue2 == 1)
            {
                NextGame = "TextGame1";
              //  RuleText.text = "COVFEFE: TAP the correct letters";
            }
            else if (rvalue2 == 2)
            {
                NextGame = "SodaGame";
             //   RuleText.text = "CHUG DIET SODA: CLICK and HOLD soda";
            }

            else if (rvalue2 == 3)
            {
                NextGame = "WallGame";
              //  RuleText.text = "BUILD THE WALL: TAP to place missing bricks";
            }
            else if (rvalue2 == 4)
            {
                NextGame = "GrabCatGame";
              //  RuleText.text = "GRAB THE PUSSY: TAP to grab the pussy";
            }

            else if (rvalue2 == 5)
            {
                NextGame = "SteakGame";
              //  RuleText.text = "SHAKE THE KETCHUP! CLICk and DRAG to prepare your meal";
            }
            else if (rvalue2 == 6)
            {
                NextGame = "ButinGame";
                //  RuleText.text = "PROTECT BUTIN: CLICK to hide Butin";
            }

            else if (rvalue2 == 7)
            {
                NextGame = "CombGame";
              //  RuleText.text = "READY THE NUKES: TAP the keys in time";
            }

            else if (rvalue2 == 8)
            {
                NextGame = "GrabWomanGame";
             //   RuleText.text = "GRAB THE PUSSY: TAP to grab the pussy";
            }
            else if (rvalue2 == 9)
            {
                NextGame = "EarthGame";
              //  RuleText.text = "CLICK THE USA to exit the Paris agreement";
            }
            else if (rvalue2 == 10)
            {
                NextGame = "PipeGame";
              //  RuleText.text = "Drag the pipes to the pipeline";
            }
            else if (rvalue2 == 11)
            {
                NextGame = "MoneyGame";
            //    RuleText.text = "PORN STAR HUSH MONEY: CLICK and DRAG only 130,000 dollars";
            }
            else if (rvalue2 == 12)
            {
                NextGame = "ImmigrantsGame";
                //   RuleText.text = "KEEP THOSE IMMIGRANTS OUT!: TAP on the immigrant";
            }

            else if (rvalue2 == 13)
            {
                NextGame = "AirportGame";
             //   RuleText.text = "KEEP THOSE MUSLIMS OUT!: TAP on the muslim";
            }

            else if (rvalue2 == 14)
            {
                NextGame = "KeyGame";
                //  RuleText.text = "READY THE NUKES: TAP the keys in time";
            }
        }
    }

    
    void Update()
    {
        if (Positive == true)
        {
            Check1 = 1;
            if (CurtainGood.time >= 0.49 || (timecheck == CurtainGood.time && timecheck != 0))
            {
                SceneManager.LoadScene(NextGame);
            }
            timecheck = CurtainGood.time;
        }
        else
        {
            Check1 = 2;
            if (CurtainBad.time >= 0.49 || (timecheck == CurtainBad.time && timecheck != 0))
            {
                SceneManager.LoadScene(NextGame);
            }
            timecheck = CurtainBad.time;
        }
    }

    int RandomValue()
    {
        rep1 = PlayerPrefs.GetInt("Repeat1");
        rep2 = PlayerPrefs.GetInt("Repeat2");
        rep3 = PlayerPrefs.GetInt("Repeat3");
        orderrep = PlayerPrefs.GetInt("CurrentRepeat", 1);
        orderset = PlayerPrefs.GetInt("CurrentSets", 1);

        rvalue1 = Random.Range(0, 4);
        if (orderset == 1)
            rvalue2 = Random.Range(0, 8);
        else if (orderset == 2)
        {
            if (rvalue1 == 0)
                rvalue2 = Random.Range(8, 15);
            else
                rvalue2 = Random.Range(0, 8);
        }
        else if (orderset == 3)
        {
            if (rvalue1 <= 1)
                rvalue2 = Random.Range(8, 15);
            else
                rvalue2 = Random.Range(0, 8);
        }
        else if (orderset == 4)
        {
            if (rvalue1 <= 2)
                rvalue2 = Random.Range(8, 15);
            else
                rvalue2 = Random.Range(0, 8);
        }
        //rvalue2 = 0;
        while(rvalue2 == rep1 || rvalue2 == rep2 || rvalue2 == rep3)
        {
            if (rvalue2 == 0)
                rvalue2 = 7;
            else if (rvalue2 == 7)
                rvalue2 = 14;
            else
                rvalue2--;
        }

        if(orderrep == 1)
        {
            PlayerPrefs.SetInt("Repeat1", rvalue2);
            PlayerPrefs.SetInt("CurrentRepeat", 2);
        }
        else if (orderrep == 2)
        {
            PlayerPrefs.SetInt("Repeat2", rvalue2);
            PlayerPrefs.SetInt("CurrentRepeat", 1);
        }
        else if (orderrep == 3)
        {
            PlayerPrefs.SetInt("Repeat3", rvalue2);
            PlayerPrefs.SetInt("CurrentRepeat", 1);
        }
        return rvalue2;
    }
}
