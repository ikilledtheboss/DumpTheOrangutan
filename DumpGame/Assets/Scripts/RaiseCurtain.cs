using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class RaiseCurtain : MonoBehaviour
{
    public GameObject StageSetUp, Self;
    public int Score, Lives, Win, rvalue1, Game, rvalue3, rep1, rep2, rep3, rep4, orderrep, orderset;
    public float T;
    public double timecheck;
    public bool Finish;
    public string NextGame;
    public PlayableDirector Curtain;

    // Use this for initialization
    void Start()
    {
        Curtain.Play();
        Finish = false;
        Lives = PlayerPrefs.GetInt("PLives");
        Score = PlayerPrefs.GetInt("PScore");
        Game = PlayerPrefs.GetInt("CurrentGame");
        timecheck = -1;

        if (Score >= 15)
        {
           
        }
        else if (Lives <= 0)
        {

        }
        else if (Game == 0)
        {
            NextGame = "GolfAnimatedGame";
            //  RuleText.text = "DUMP RESORT: TAP at the right moment";
        }
        else if (Game == 1)
        {
            NextGame = "TextGame1";
            //  RuleText.text = "COVFEFE: TAP the correct letters";
        }
        else if (Game == 2)
        {
            NextGame = "SodaGame";
            //   RuleText.text = "CHUG DIET SODA: CLICK and HOLD soda";
        }

        else if (Game == 3)
        {
            NextGame = "WallGame";
            //  RuleText.text = "BUILD THE WALL: TAP to place missing bricks";
        }
        else if (Game == 4)
        {
            NextGame = "GrabCatGame";
            //  RuleText.text = "GRAB THE PUSSY: TAP to grab the pussy";
        }

        else if (Game == 5)
        {
            NextGame = "SteakGame";
            //  RuleText.text = "SHAKE THE KETCHUP! CLICk and DRAG to prepare your meal";
        }

        else if (Game == 6)
        {
            NextGame = "ImmigrantsGame";
            //   RuleText.text = "KEEP THOSE IMMIGRANTS OUT!: TAP on the immigrant";
        }

        else if (Game == 7)
        {
            NextGame = "KeyGame";
            //  RuleText.text = "READY THE NUKES: TAP the keys in time";
        }

        else if (Game == 8)
        {
            NextGame = "GrabWomanGame";
            //   RuleText.text = "GRAB THE PUSSY: TAP to grab the pussy";
        }
        else if (Game == 9)
        {
            NextGame = "EarthGame";
            //  RuleText.text = "CLICK THE USA to exit the Paris agreement";
        }
        else if (Game == 10)
        {
            NextGame = "PipeGame";
            //  RuleText.text = "Drag the pipes to the pipeline";
        }
        else if (Game == 11)
        {
            NextGame = "MoneyGame";
            //    RuleText.text = "PORN STAR HUSH MONEY: CLICK and DRAG only 130,000 dollars";
        }
        else if (Game == 12)
        {
            NextGame = "ButinGame";
            //  RuleText.text = "PROTECT BUTIN: CLICK to hide Butin";
        }

        else if (Game == 13)
        {
            NextGame = "AirportGame";
            //   RuleText.text = "KEEP THOSE MUSLIMS OUT!: TAP on the muslim";
        }
        //   ScoreText.text = Score.ToString() + " POINTS";
        // LivesText.text = Lives.ToString() + " LIVES";

    }


    void Update()
    {
        if (Curtain.time >= 3.4 || (timecheck == Curtain.time && timecheck != 0))
        {
            Finish = false;
            StageSetUp.SetActive(false);
            if (Score >= 15)
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
                Self.GetComponent<GameHome>().enabled = true;
            }

            else if (Game == 7)
            {
                Self.GetComponent<GameKeys>().enabled = true;
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
                Self.GetComponent<GameButin>().enabled = true;
            }

            else if (Game == 13)
            {
                Self.GetComponent<GameAirport>().enabled = true;
            }
            Self.GetComponent<RaiseCurtain>().enabled = false;
            //GameStart
            // SceneManager.LoadScene(NextGame);
        }
        timecheck = Curtain.time;
    }
}
