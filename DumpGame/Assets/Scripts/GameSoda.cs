using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSoda : MonoBehaviour
{
    public GameObject Drink, Dump, Curtain, ScoreKeeper;
    public SpriteRenderer Drinksr;
    public Sprite D0, D2, D3, D4, D5;
    public int Progress, Win, Dragged;
    public float T, Dx, Dy, Chug;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;
    
    void Start ()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Progress = 1;
        Win = 0;
        T = PlayerPrefs.GetFloat("PTime");
        Chug = 0;
        Drinksr = Drink.GetComponent<SpriteRenderer>();
        if (T < 3)
            Chug = 1.01f;
        else if (T < 4)
            Chug = 0.51f;
    
        Dragged = Drink.GetComponent<ClickDragItem>().Drag;
        Curtain.GetComponent<UpFlag>().enabled = true;
        tt = T;
    }
	
	void Update ()
    {
        Dragged = Drink.GetComponent<ClickDragItem>().Drag;
        if (Progress != 0)
        {
            Dx = Drink.transform.position.x;
            Dy = Drink.transform.position.y;

            if (Chug >= 1.2f)
            {
                Progress = 2;
                Drinksr.sprite = D4;
            }
            else if (Chug >= 0.8f)
                Drinksr.sprite = D3;
            else if (Chug >= 0.4f)
                Drinksr.sprite = D2;

            if (Dx > 8.3f || Dx < -8.3f)
            {
                Drinksr.sprite = D0;
                Win = 0;
                Progress = 0;
            }
            else if (Dy < -5.5 || Dy > 4.3f)
            {
                Drinksr.sprite = D0;
                Win = 0;
                Progress = 0;
            }

           else if(Dy < 1.4f && Dx < 4.5f && Dx > -4.3f )
            {
                Drinksr.sprite = D0;
                Win = 0;
                Progress = 0;
            }
            else if(Dy < -3.3f && Dx > -8.3 && Dx < -4.4f)
            {
                if(Progress == 2)
                {
                    Drinksr.sprite = D5;
                    Win = 1;
                    Progress = 0;
                }
            }
        }

        if(Dragged == 2 && Win != 1)
        {
            Drinksr.sprite = D0;
            Win = 0;
            Progress = 0;
        }

        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Curtain.GetComponent<DownFlag>().enabled = true;
            Curtain.GetComponent<PresentResults>().enabled = true;
            Dump.GetComponent<GameSoda>().enabled = false;
        }

        else
        {
            T = T - Time.deltaTime;

            if(Dx < 4.5f && Dx > 0.3f && Dy > 1.4f && Dy < 4.3f)
            {
                Chug = Chug + Time.deltaTime;
            }
        }
    }
}
