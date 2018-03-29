using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameAirport : MonoBehaviour {

    public GameObject p1, p2, p3, p4, p5, p6, p7, p8, p9, Immigrant, Dump, Curtain, ScoreKeeper;
    public SpriteRenderer DumpSR;
    public Sprite s1, s2, s3, s4, s5, s6, s7, s8, s9, im;
    public int Win;
    public bool Clicked;
    public float T;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;
    
    void Start ()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Win = 0;
        Clicked = Immigrant.GetComponent<ClickItem>().Clicked;
        DumpSR = Dump.GetComponent<SpriteRenderer>();
        DumpSR.enabled = false;
        T = PlayerPrefs.GetFloat("PTime");
        Curtain.GetComponent<UpFlag>().enabled = true;
        tt = T;
    }
	
	void Update ()
    {
        Clicked = Immigrant.GetComponent<ClickItem>().Clicked;
        if (Clicked == true)
        {
            DumpSR.enabled = true;
            p1.GetComponent<SpriteRenderer>().sprite = s1;
            p2.GetComponent<SpriteRenderer>().sprite = s2;
            p3.GetComponent<SpriteRenderer>().sprite = s3;
            p4.GetComponent<SpriteRenderer>().sprite = s4;
            p5.GetComponent<SpriteRenderer>().sprite = s5;
            p6.GetComponent<SpriteRenderer>().sprite = s6;
            p7.GetComponent<SpriteRenderer>().sprite = s7;
            p8.GetComponent<SpriteRenderer>().sprite = s8;
            p9.GetComponent<SpriteRenderer>().sprite = s9;
            Immigrant.GetComponent<SpriteRenderer>().sprite = im;
            Win = 1;
        }

        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Curtain.GetComponent<DownFlag>().enabled = true;
            Curtain.GetComponent<PresentResults>().enabled = true;
            Dump.GetComponent<GameAirport>().enabled = false;
        }
        else
        {
            T = T - Time.deltaTime;
        }
    }
}
