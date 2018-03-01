using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string StageScene;
    public GameObject ScoreKeeper;
    public int Lives, Score, PResult;
    public float Time;

    void OnMouseDown()
    {
        PlayerPrefs.SetInt ("PLives", Lives);
        PlayerPrefs.SetInt ("PScore", Score);
        PlayerPrefs.SetFloat ("PTime", Time);
        PlayerPrefs.SetInt("Result",PResult);
        StageScene = "StageScene";
        SceneManager.LoadScene(StageScene);
    }
}
