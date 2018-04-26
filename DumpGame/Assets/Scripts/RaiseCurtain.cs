using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class RaiseCurtain : MonoBehaviour
{
    public GameObject StageSetUp, Self, L1, L2, S1, S2, Liveshow, Scoreshow, Ruleshow, hp3, hp2, hp1, Healthbar;
    public int Score, Lives, Game;
    public Sprite n0, n1, n2, n3, n4, n5, n6, n7, n8, n9; 
    public float T;
    public double timecheck;
    public bool Finish;
    public string NextGame;
    public PlayableDirector Curtain;
    
    void Start()
    {
        Curtain.Play();
        Finish = false;
        Lives = PlayerPrefs.GetInt("PLives");
        Score = PlayerPrefs.GetInt("PScore");
        Game = PlayerPrefs.GetInt("CurrentGame");

        if (Score >= 20)
            S1.GetComponent<SpriteRenderer>().sprite = n2;
        else if (Score >= 10)
            S1.GetComponent<SpriteRenderer>().sprite = n1;
        else
            S1.GetComponent<SpriteRenderer>().sprite = n0;

        if (Score % 10 == 9)
            S2.GetComponent<SpriteRenderer>().sprite = n9;
        else if (Score % 10 == 8)
            S2.GetComponent<SpriteRenderer>().sprite = n8;
        else if (Score % 10 == 7)
            S2.GetComponent<SpriteRenderer>().sprite = n7;
        else if (Score % 10 == 6)
            S2.GetComponent<SpriteRenderer>().sprite = n6;
        else if (Score % 10 == 5)
            S2.GetComponent<SpriteRenderer>().sprite = n5;
        else if (Score % 10 == 4)
            S2.GetComponent<SpriteRenderer>().sprite = n4;
        else if (Score % 10 == 3)
            S2.GetComponent<SpriteRenderer>().sprite = n3;
        else if (Score % 10 == 2)
            S2.GetComponent<SpriteRenderer>().sprite = n2;
        else if (Score % 10 == 1)
            S2.GetComponent<SpriteRenderer>().sprite = n1;
        else if (Score % 10 == 0)
            S2.GetComponent<SpriteRenderer>().sprite = n0;


        if (Lives >= 10)
            L1.GetComponent<SpriteRenderer>().sprite = n1;
        else
            L1.GetComponent<SpriteRenderer>().sprite = n0;

        if (Lives % 10 == 9)
            L2.GetComponent<SpriteRenderer>().sprite = n9;
        else if (Lives % 10 == 8)
            L2.GetComponent<SpriteRenderer>().sprite = n8;
        else if (Lives % 10 == 7)
            L2.GetComponent<SpriteRenderer>().sprite = n7;
        else if (Lives % 10 == 6)
            L2.GetComponent<SpriteRenderer>().sprite = n6;
        else if (Lives % 10 == 5)
            L2.GetComponent<SpriteRenderer>().sprite = n5;
        else if (Lives % 10 == 4)
            L2.GetComponent<SpriteRenderer>().sprite = n4;
        else if (Lives % 10 == 3)
            L2.GetComponent<SpriteRenderer>().sprite = n3;
        else if (Lives % 10 == 2)
            L2.GetComponent<SpriteRenderer>().sprite = n2;
        else if (Lives % 10 == 1)
            L2.GetComponent<SpriteRenderer>().sprite = n1;
        else if (Lives % 10 == 0)
            L2.GetComponent<SpriteRenderer>().sprite = n0;

        if (Lives >= 3)
            Healthbar = hp3;
        else if (Lives == 2)
            Healthbar = hp2;
        else
            Healthbar = hp1;
        Healthbar.SetActive(true);
        Healthbar.GetComponent<PlayableDirector>().Play();
        timecheck = -1;
    }

    void Update()
    {
        if (Curtain.time >= 3.4 || (timecheck == Curtain.time && timecheck != 0))
        {
            Finish = false;
            StageSetUp.SetActive(false);

            if (Score >= 20)
            {
                Self.GetComponent<GameVote>().enabled = true;
            }
            else if (Game == 0)
            {
                Self.GetComponent<GolfGameplay>().enabled = true;
            }
            else if (Game == 1)
            {
                Self.GetComponent<GamePhone>().enabled = true;
            }
            else if (Game == 2)
            {
                Self.GetComponent<GameSodaTap>().enabled = true;
            }

            else if (Game == 3)
            {
                Self.GetComponent<GameBuildWall>().enabled = true;
            }
            else if (Game == 4)
            {
                Self.GetComponent<GameGrabWoman>().enabled = true;
            }

            else if (Game == 5)
            {
                Self.GetComponent<GameSteak>().enabled = true;
            }

            else if (Game == 6)
            {
                Self.GetComponent<GameButin>().enabled = true;
            }

            else if (Game == 7)
            {
                Self.GetComponent<GameComb>().enabled = true;
            }

            else if (Game == 8)
            {
                Self.GetComponent<GameGrabWoman>().enabled = true;
            }
            else if (Game == 9)
            {
                Self.GetComponent<GameEarth>().enabled = true;
            }
            else if (Game == 10)
            {
                Self.GetComponent<GamePipe>().enabled = true;
            }
            else if (Game == 11)
            {
                Self.GetComponent<GameMoney>().enabled = true;
            }
            else if (Game == 12)
            {
                Self.GetComponent<GameHome>().enabled = true;
            }
            else if (Game == 13)
            {
                Self.GetComponent<GameAirport>().enabled = true;
            }
            else if (Game == 14)
            {
                Self.GetComponent<GameKeys>().enabled = true;
            }

            Liveshow.GetComponent<SpriteRenderer>().enabled = false;
            Scoreshow.GetComponent<SpriteRenderer>().enabled = false;
            Ruleshow.GetComponent<SpriteRenderer>().enabled = false;
            L1.GetComponent<SpriteRenderer>().enabled = false;
            L2.GetComponent<SpriteRenderer>().enabled = false;
            S1.GetComponent<SpriteRenderer>().enabled = false;
            S2.GetComponent<SpriteRenderer>().enabled = false;
            Healthbar.GetComponent<PlayableDirector>().Stop();
            Healthbar.SetActive(false);

            Self.GetComponent<RaiseCurtain>().enabled = false;
        }
        timecheck = Curtain.time;
    }
}
