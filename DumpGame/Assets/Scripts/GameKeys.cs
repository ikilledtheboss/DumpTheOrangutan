using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class GameKeys : MonoBehaviour
{
    public int Win;
    public GameObject Self, ScoreKeeper;
    public float T;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;
    public PlayableDirector Drop;

    void Start()
    {
        Drop.Play();
        Self.GetComponent<Button>().enabled = true;
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Win = 0;
        T = PlayerPrefs.GetFloat("PTime");
        tt = T;
    }


    void Update()
    {
        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Self.GetComponent<PresentResults>().enabled = true;
            Self.GetComponent<GameKeys>().enabled = false;
        }

        else
        {
            T = T - Time.deltaTime;
        }
    }
}
