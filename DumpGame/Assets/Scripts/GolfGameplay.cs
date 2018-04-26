using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class GolfGameplay : MonoBehaviour
{
    public int Win, progress;
    public GameObject Self;
    public float T;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;
    public PlayableDirector Gauge;

    void Start()
    {
        Gauge.Play();
        Self.GetComponent<Button>().enabled = true;
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Win = 0;
        T = PlayerPrefs.GetFloat("PTime");
        tt = T;
        progress = 0;
    }
    
    public void TurnOff()
    {
        Gauge.Stop();
    }

    void Update()
    {
        if (T< 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Self.GetComponent<PresentResults>().enabled = true;
            Self.GetComponent<GolfGameplay>().enabled = false;
        }

        else
        {
            T = T - Time.deltaTime;
        }   
    }
}
