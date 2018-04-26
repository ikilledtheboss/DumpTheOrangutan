using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEarth : MonoBehaviour
{

    public GameObject Self, earthone, earthlast, earthchange, f1, f2, f3, f4 ,f5, Curtain;
    public Sprite store, s1, s2, s3, end;
    public int Progress, Win;
    public float T;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;

    void Start()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Win = 0;
        Progress = 1;
        T = PlayerPrefs.GetFloat("PTime");
        Curtain.GetComponent<UpFlag>().enabled = true;
        tt = T;
    }

    public void Results()
    {
        Progress = 2;
        Win = 1;
        Self.GetComponent<Button>().interactable = false;
        earthone.GetComponent<SpriteRenderer>().enabled = false;
        earthchange.GetComponent<Animator>().enabled = true;
        earthchange.GetComponent<SpriteRenderer>().enabled = true;
    }

    void Update()
    {
        if (Progress == 2)
        {
            store = earthchange.GetComponent<SpriteRenderer>().sprite;
            if(store == s1)
            {
                f1.GetComponent<Animator>().enabled = true;
                f1.GetComponent<SpriteRenderer>().enabled = true;
            }
            else if (store == s2)
            {
                f2.GetComponent<Animator>().enabled = true;
                f2.GetComponent<SpriteRenderer>().enabled = true;
            }
            else if (store == s3)
            {
                f3.GetComponent<Animator>().enabled = true;
                f3.GetComponent<SpriteRenderer>().enabled = true;
                f4.GetComponent<Animator>().enabled = true;
                f4.GetComponent<SpriteRenderer>().enabled = true;
            }
            else if (store == end)
            {
                Progress = 3;
                f5.GetComponent<Animator>().enabled = true;
                f5.GetComponent<SpriteRenderer>().enabled = true;
                earthchange.GetComponent<Animator>().enabled = false;
                earthchange.GetComponent<SpriteRenderer>().enabled = false;
                earthlast.GetComponent<SpriteRenderer>().enabled = true;
            }
        }

        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Self.GetComponent<PresentResults>().enabled = true;
            Self.GetComponent<GameEarth>().enabled = false;
        }
        else
        {
            T = T - Time.deltaTime;
        }
    }
}

