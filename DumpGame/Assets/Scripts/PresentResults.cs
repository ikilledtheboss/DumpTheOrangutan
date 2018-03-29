
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PresentResults : MonoBehaviour
{
    public GameObject TimeText, Curtain;
    public Text ScoreText, LivesText, RuleText;
    public int Score, Lives, Win, rvalue;
    public float T;
    public string NextGame, finish;
    public double tt;

    // Use this for initialization
    void Start()
    {
        Curtain.GetComponent<Countdown>().enabled = true;
        finish = "MainMenu";
        rvalue = Random.Range(0, 7);
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
            SceneManager.LoadScene(finish);
        if (Lives == 0)
            SceneManager.LoadScene(finish);

        if (Score == 12)
            PlayerPrefs.SetFloat("PTime", 2.5f);
        if (Score == 8)
            PlayerPrefs.SetFloat("PTime", 3.5f);
        if (Score == 4)
            PlayerPrefs.SetFloat("PTime", 4.5f);

        T = PlayerPrefs.GetFloat("PTime");

        if (rvalue == 0)
        {
            NextGame = "GolfGame";
            RuleText.text = "TIME your golf stroke by clicking the mouse";
        }
        else if (rvalue == 1)
        {
            NextGame = "TextGame1";
            RuleText.text = "CLICK the words to complete the text";
        }
        else if (rvalue == 2)
        {
            NextGame = "ImmigrantGame";
            RuleText.text = "CLICK the guilty party";
        }

        else if (rvalue == 3)
        {
            NextGame = "WallGame";
            RuleText.text = "CLICK on the broken wall to fix";
        }

        else if (rvalue == 4)
        {
            NextGame = "MoneyGame";
            RuleText.text = "DRAG the money to the visitor";
        }

        else if (rvalue == 5)
        {
            NextGame = "AirportGame";
            RuleText.text = "CLICK on the Muslim individual";
        }

        else if (rvalue == 6)
        {
            NextGame = "SodaGame";
            RuleText.text = "DRAG and drink the soda, and recycle";
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

}
