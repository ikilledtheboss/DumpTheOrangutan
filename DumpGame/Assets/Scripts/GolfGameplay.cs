using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GolfGameplay : MonoBehaviour
{
    public int Win;
    public GameObject Self, Curtain,  ScoreKeeper;
    public float T;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;

    void Start()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Win = 0;
        T = PlayerPrefs.GetFloat("PTime");
        Curtain.GetComponent<UpFlag>().enabled = true;
        tt = T;
    }
    
    
    void Update()
    {
        if (T< 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Curtain.GetComponent<DownFlag>().enabled = true;
            Curtain.GetComponent<PresentResults>().enabled = true;
            Self.GetComponent<GolfGameplay>().enabled = false;
        }

        else
        {
            T = T - Time.deltaTime;
        }   
    }
}
