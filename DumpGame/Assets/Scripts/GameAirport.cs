using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameAirport : MonoBehaviour {

    public GameObject Immigrant, Dump, Curtain, ScoreKeeper;
    public SpriteRenderer DumpSR;
    public Sprite im;
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
