using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameAirport : MonoBehaviour
{
    public GameObject Self;
    public int Win;
    public float T;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;

    void Start ()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Win = 0;
        T = PlayerPrefs.GetFloat("PTime");
        tt = T;
    }

    public void Results()
    {
        Win = 1;
    }

	void Update ()
    {
        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Self.GetComponent<PresentResults>().enabled = true;
            Self.GetComponent<GameAirport>().enabled = false;
        }
        else
        {
            T = T - Time.deltaTime;
        }
    }
}
