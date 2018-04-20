using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public string StageScene;
    public GameObject StartButton, Curtain, t1, t2, t3, t4, TimeText;
    public bool Classic;
    public int Lives, Score, PResult, apple;
    public float Time;
    public Text ScoreText, LivesText, RuleText;

    void Start()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        TimeText.GetComponent<Text>().enabled = false;
        Classic = StartButton.GetComponent<ClickItem>().Clicked;
    }

    void Update()
    {
        Classic = StartButton.GetComponent<ClickItem>().Clicked;
        if(Classic == true)
            ClassicStart();
    }

    public void QuitGame()
    {
        apple = 1;
        Application.Quit();
    }

    void ClassicStart()
    {
        PlayerPrefs.SetInt ("PLives", Lives);
        PlayerPrefs.SetInt ("PScore", Score);
        PlayerPrefs.SetFloat ("PTime", Time);
        PlayerPrefs.SetInt("Result",PResult);

        PlayerPrefs.SetInt("Repeat1", -1);
        PlayerPrefs.SetInt("Repeat2", -1);
        PlayerPrefs.SetInt("Repeat3", -1);

        PlayerPrefs.SetInt("CurrentRepeat", 1);
        PlayerPrefs.SetInt("CurrentSets", 1);

        Curtain.GetComponent<DownFlag>().enabled = true;
        t1.GetComponent<Text>().enabled = false;
        t2.GetComponent<Text>().enabled = false;
        t3.GetComponent<Text>().enabled = false;
        t4.GetComponent<Text>().enabled = false;
        TimeText.GetComponent<Text>().enabled = true;
        //TimeText.GetComponent<Countdown>().enabled = true;
        Curtain.GetComponent<PresentResults>().enabled = true;
        StartButton.GetComponent<StartGame>().enabled = false;
        //StageScene = "StageScene";
        //SceneManager.LoadScene(StageScene);
    }
}