using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restarter : MonoBehaviour
{

    public GameObject Curtain;
    public Text ScoreText;
    public bool Ready;
    public int Score;
    public string NextGame;

    void Start()
    {
        Score = PlayerPrefs.GetInt("PScore");
        ScoreText.text = "Your final score is " + Score.ToString() + " POINTS!";
        Ready = false;
    }
    void Update()
    {
        if (Curtain.GetComponent<DownFlag>().enabled == false && Ready == true)
        {
            NextGame = "MainMenu";
            SceneManager.LoadScene(NextGame);
        }
    }

    public void Restarting()
    {
        ScoreText.enabled = false;
        Curtain.GetComponent<DownFlag>().enabled = true;
        Ready = true;
    }
}