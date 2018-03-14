using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUpdate : MonoBehaviour {
    public GameObject TimeText;
    public Text ScoreText, LivesText;
    public int Score, Lives, Win, rvalue;
    public float T;
    public string NextGame, finish;

	// Use this for initialization
	void Start ()
    {
        finish = "MainMenu";
        rvalue = Random.Range(0,3);

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
            PlayerPrefs.SetFloat("PTime", 2);
        if (Score == 8)
            PlayerPrefs.SetFloat("PTime", 3);
        if (Score == 4)
            PlayerPrefs.SetFloat("PTime", 4);

        T =  PlayerPrefs.GetFloat("PTime");

        if(rvalue == 0)
            NextGame = "TextGame1";
        else if (rvalue == 1)
            NextGame = "GolfGame";
        else if (rvalue == 2)
            NextGame = "HomeGame";
        ScoreText.text = Score.ToString() + " POINTS";
        LivesText.text = Lives.ToString() + " LIVES";

    }
	
	// Update is called once per frame
	void Update ()
    {
        T = TimeText.GetComponent<Countdown>().T;
        if (T < 0)
            end();
    }

    void end()
    {
       SceneManager.LoadScene(NextGame);
    }

}
