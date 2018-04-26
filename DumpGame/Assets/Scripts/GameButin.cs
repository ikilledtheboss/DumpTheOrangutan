using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameButin : MonoBehaviour
{
    public GameObject Button1, Button2, Button3, Self, Curtain;
    public int Progress, Win;
    public float T;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;

    void Start()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Button2.GetComponent<Button>().enabled = false;
        Button3.GetComponent<Button>().enabled = false;
        Progress = 1;
        Win = 0;
        T = PlayerPrefs.GetFloat("PTime");
        Curtain.GetComponent<UpFlag>().enabled = true;
        tt = T;
    }

    public void FirstClick()
    {
        Progress = 2;
        Button1.GetComponent<Button>().enabled = false;
        Button2.GetComponent<Button>().enabled = true;
    }

    public void SecondClick()
    {
        Progress = 3;
        Button2.GetComponent<Button>().enabled = false;
        Button3.GetComponent<Button>().enabled = true;
        Button3.transform.Translate(0, 2.2f, 0);
    }

    public void ThirdClick()
    {
        Win = 1;
        Progress = 4;
        Button3.GetComponent<Button>().enabled = false;
    }

    void Update()
    {
        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Self.GetComponent<PresentResults>().enabled = true;
            Self.GetComponent<GameButin>().enabled = false;
        }
        else
        {
            T = T - Time.deltaTime;
        }
    }
}
