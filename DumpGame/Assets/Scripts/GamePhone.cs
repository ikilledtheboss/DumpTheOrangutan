using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePhone : MonoBehaviour
{
    public GameObject Covfefe1, Covfefe2, Covfefe3, Phone, Curtain1, Curtain2, ScoreKeeper;
    public SpriteRenderer PhoneSR;
    public Sprite Phone0, Phone2, Phone3, Phone4;
    public int Progress, Win;
    public bool C1, C2, C3, FlagDown;
    public float T;
    public string StageScene;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;

    void Start()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        StageScene = "StageScene";
        Progress = 1;
        Win = 0;
        PhoneSR = Phone.GetComponent<SpriteRenderer>();
        C1 = Covfefe1.GetComponent<ClickItem>().Clicked;
        C2 = Covfefe2.GetComponent<ClickItem>().Clicked;
        C3 = Covfefe3.GetComponent<ClickItem>().Clicked;
        FlagDown = false;
        T = PlayerPrefs.GetFloat("PTime");
        Curtain1.GetComponent<UpFlag>().enabled = true;
        tt = T;
    }

    void Update()
    {
        switch (Progress)
        {
            case (1):
                if (C1 == true)
                {
                    Progress = 2;
                    PhoneSR.sprite = Phone2;
                }
                else if (C2 == true || C3 == true)
                {
                    Progress = 0;
                    PhoneSR.sprite = Phone0;
                    Win = 0;
                }
                C1 = Covfefe1.GetComponent<ClickItem>().Clicked;
                C2 = Covfefe2.GetComponent<ClickItem>().Clicked;
                C3 = Covfefe3.GetComponent<ClickItem>().Clicked;
                break;

            case (2):
                if (C2 == true)
                {
                    Progress = 3;
                    PhoneSR.sprite = Phone3;
                }
                else if (C3 == true)
                {
                    Progress = 0;
                    PhoneSR.sprite = Phone0;
                    Win = 0;
                }
                C1 = Covfefe1.GetComponent<ClickItem>().Clicked;
                C2 = Covfefe2.GetComponent<ClickItem>().Clicked;
                C3 = Covfefe3.GetComponent<ClickItem>().Clicked;
                break;

            case (3):
                if (C3 == true)
                {
                    Progress = 4;
                    PhoneSR.sprite = Phone4;
                    Win = 1;
                }
                C1 = Covfefe1.GetComponent<ClickItem>().Clicked;
                C2 = Covfefe2.GetComponent<ClickItem>().Clicked;
                C3 = Covfefe3.GetComponent<ClickItem>().Clicked;
                break;

            default:
                break;
        }

        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Curtain1.GetComponent<DownFlag>().enabled = true;
            Curtain1.GetComponent<PresentResults>().enabled = true;
            Phone.GetComponent<GamePhone>().enabled = false;
        }
        else
        {
            T = T - Time.deltaTime;
        }
    }
}
