
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PresentResults : MonoBehaviour
{
    public GameObject TimeText, Curtain;
    public Text ScoreText, LivesText, RuleText;
    public int Score, Lives, Win, rvalue1, rvalue2, rep1, rep2, rep3, rep4, orderrep, orderset;
    public float T;
    public string NextGame;
    public double tt;

    // Use this for initialization
    void Start()
    {
        Curtain.GetComponent<Countdown>().enabled = true;
        Lives = PlayerPrefs.GetInt("PLives");
        Score = PlayerPrefs.GetInt("PScore");
        Win = PlayerPrefs.GetInt("Result");

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

        if (Score == 15)
        {
            NextGame = "WinScreen";
            SceneManager.LoadScene(NextGame);
        }
        if (Lives == 0)
        {
            NextGame = "LoseScreen";
            SceneManager.LoadScene(NextGame);
        }

        if (Score == 12)
        {
            PlayerPrefs.SetInt("CurrentSets", 4);
            PlayerPrefs.SetFloat("PTime", 3.5f);
        }
        if (Score == 8)
        { 
            PlayerPrefs.SetInt("CurrentSets", 3);
            PlayerPrefs.SetFloat("PTime", 4.5f);
        }
        if (Score == 4)
        {
            PlayerPrefs.SetInt("CurrentSets", 2);
            PlayerPrefs.SetFloat("PTime", 5.5f);
        }

        T = PlayerPrefs.GetFloat("PTime");

        rvalue2 = RandomValue();
       
        if (rvalue2 == 0)
        {
            NextGame = "GolfAnimatedGame";
            RuleText.text = "DUMP RESORT: TAP at the right moment";
        }
        else if (rvalue2 == 1)
        {
            NextGame = "TextGame1";
            RuleText.text = "TCOVFEFE: TAP the correct letters";
        }
        else if (rvalue2 == 2)
        {
            NextGame = "SodaGame";
            RuleText.text = "CHUG DIET SODA: CLICK and DRAG soda to Dump's mouth";
        }

        else if (rvalue2 == 3)
        {
            NextGame = "WallGame";
            RuleText.text = "BUILD THE WALL: TAP to place missing bricks";
        }

        else if (rvalue2 == 4)
        {
            NextGame = "MoneyGame";
            RuleText.text = "PORN STAR HUSH MONEY: CLICK and DRAG only 130,000 dollars";
        }

        else if (rvalue2 == 5)
        {
            NextGame = "AirportGame";
            RuleText.text = "KEEP THOSE MUSLIMS OUT!: TAP on the muslim";
        }

        else if (rvalue2 == 6)
        {
            NextGame = "ImmigrantsGame";
            RuleText.text = "KEEP THOSE IMMIGRANTS OUT!: TAP on the immigrant";
        }

        else if (rvalue2 == 7)
        {
            NextGame = "KeyGame";
            RuleText.text = "READY THE NUKES: TAP the keys in time";
        }

        ScoreText.text = Score.ToString() + " POINTS";
        LivesText.text = Lives.ToString() + " LIVES";

        tt = T;

    }
    
    void Update()
    {
        if (T < 0)
            end();
        else
        {
            T = Curtain.GetComponent<Countdown>().T;
            tt = Curtain.GetComponent<Countdown>().tt;
            TimeText.GetComponent<Text>().text = tt.ToString() + " Seconds Left";
        }
    }

    void end()
    {
        SceneManager.LoadScene(NextGame);
    }

    int RandomValue()
    {
        rep1 = PlayerPrefs.GetInt("Repeat1");
        rep2 = PlayerPrefs.GetInt("Repeat2");
       // rep3 = PlayerPrefs.GetInt("Repeat3");
        orderrep = PlayerPrefs.GetInt("CurrentRepeat", 1);
        orderset = PlayerPrefs.GetInt("CurrentSets", 1);

        rvalue1 = Random.Range(0, 4);
        if (orderset == 1)
            rvalue2 = Random.Range(0, 4);
        else if (orderset == 2)
        {
            if (rvalue1 == 0)
                rvalue2 = Random.Range(4, 8);
            else
                rvalue2 = Random.Range(0, 4);
        }
        else if (orderset == 3)
        {
            if (rvalue1 <= 1)
                rvalue2 = Random.Range(4, 8);
            else
                rvalue2 = Random.Range(0, 4);
        }
        else if (orderset == 4)
        {
            if (rvalue1 <= 2)
                rvalue2 = Random.Range(4, 8);
            else
                rvalue2 = Random.Range(0, 4);
        }

        while(rvalue2 == rep1 || rvalue2 == rep2)
        {
            if (rvalue2 == 0)
                rvalue2 = 3;
            else if (rvalue2 == 4)
                rvalue2 = 7;
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
        //else if (orderrep == 3)
        //{
        //    PlayerPrefs.SetInt("Repeat3", rvalue2);
        //    PlayerPrefs.SetInt("CurrentRepeat", 1);
        //}

        return rvalue2;
    }
}
