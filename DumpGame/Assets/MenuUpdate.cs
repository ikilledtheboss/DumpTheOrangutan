using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUpdate : MonoBehaviour {
    public GameObject TimeText;
    public Text ScoreText, LivesText;
    public int Score, Lives;
    public float Time;
    public string TextGame1;

	// Use this for initialization
	void Start ()
    {
        Score = 0;
        Lives = 3;
        Time = TimeText.GetComponent<Countdown>().T;
        TextGame1 = "TextGame1";
        ScoreText.text = Score.ToString() + " POINTS";
        LivesText.text = Lives.ToString() + " LIVES";

    }
	
	// Update is called once per frame
	void Update ()
    {
        Time = TimeText.GetComponent<Countdown>().T;
        if (Time < 0)
            end();
    }

    void end()
    {
       // Application.LoadLevel(TextGame1);
       SceneManager.LoadScene(TextGame1);
    }

}
