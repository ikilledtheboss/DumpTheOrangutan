using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public string StageScene;
    public GameObject StartButton, TimeText;
    public bool Classic;
    public int Lives, Score, PResult;
    public float Time;

    void Start()
    {
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
        Application.Quit();
    }

    void ClassicStart()
    {
        PlayerPrefs.SetInt("PLives", Lives);
        PlayerPrefs.SetInt("PScore", Score);
        PlayerPrefs.SetFloat("PTime", Time);
        PlayerPrefs.SetInt("Result", PResult);

        PlayerPrefs.SetInt("Repeat1", -1);
        PlayerPrefs.SetInt("Repeat2", -1);
        PlayerPrefs.SetInt("Repeat3", -1);

        PlayerPrefs.SetInt("CurrentRepeat", 1);
        PlayerPrefs.SetInt("CurrentSets", 1);

        //TimeText.GetComponent<Countdown>().enabled = true;
        StartButton.GetComponent<PresentResults>().enabled = true;
        StartButton.GetComponent<StartGame>().enabled = false;
        //StageScene = "StageScene";
        //SceneManager.LoadScene(StageScene);
    }
}