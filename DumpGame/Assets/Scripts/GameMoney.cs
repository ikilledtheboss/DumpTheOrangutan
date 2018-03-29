using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMoney : MonoBehaviour
{

    public GameObject Money1, Money2, Money3, Money4, Pile, Curtain, ScoreKeeper;
    public SpriteRenderer Pilesr;
    public Sprite Pile0, Pile1, Pile2, Pile3, Pile4;
    public int Progress, Win, M1, M2, M3, M4;
    public float T, y1, y2, y3, y4;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;

    void Start ()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Progress = 0;
        Win = 0;
        Pilesr = Pile.GetComponent<SpriteRenderer>();
        M1 = Money1.GetComponent<ClickDragItem>().Drag;
        M2 = Money2.GetComponent<ClickDragItem>().Drag;
        M3 = Money3.GetComponent<ClickDragItem>().Drag;
        M4 = Money4.GetComponent<ClickDragItem>().Drag;
        T = PlayerPrefs.GetFloat("PTime");
        Curtain.GetComponent<UpFlag>().enabled = true;
        tt = T;
    }
	
	void Update ()
    {
        if (M1 == 2)
        {
            y1 = Money1.transform.position.y;
            if (y1 >= 0)
            {
                Progress++;
                M1++;
                Money1.GetComponent<ClickDragItem>().enabled = false;
                Money1.GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
         //       Money1.transform.position = Money1.GetComponent<ClickDragItem>().StartLoc;
                Money1.GetComponent<ClickDragItem>().Drag = 0;
            }
        }
        else if (M1 != 3) 
            M1 = Money1.GetComponent<ClickDragItem>().Drag;

        if (M2 == 2)
        {
            y2 = Money2.transform.position.y;
            if (y2 >= 0)
            {
                Progress++;
                M2++;
                Money2.GetComponent<ClickDragItem>().enabled = false;
                Money2.GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
          //      Money2.transform.position = Money2.GetComponent<ClickDragItem>().StartLoc;
                Money2.GetComponent<ClickDragItem>().Drag = 0;
            }
        }
        else if (M2 != 3)
            M2 = Money2.GetComponent<ClickDragItem>().Drag;

        if (M3 == 2)
        {
            y3 = Money3.transform.position.y;
            if (y3 >= 0)
            {
                Progress++;
                M3++;
                Money3.GetComponent<ClickDragItem>().enabled = false;
                Money3.GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
           //     Money3.transform.position = Money3.GetComponent<ClickDragItem>().StartLoc;
                Money3.GetComponent<ClickDragItem>().Drag = 0;
            }
        }
        else if (M3 != 3)
            M3 = Money3.GetComponent<ClickDragItem>().Drag;

        if (M4 == 2)
        {
            y4 = Money4.transform.position.y;
            if (y4 >= 0)
            {
                Progress++;
                M4++;
                Money4.GetComponent<ClickDragItem>().enabled = false;
                Money4.GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
          //      Money4.transform.position = Money4.GetComponent<ClickDragItem>().StartLoc;
                Money4.GetComponent<ClickDragItem>().Drag = 0;
            }
        }
        else if (M4 != 3)
            M4 = Money4.GetComponent<ClickDragItem>().Drag;

        switch (Progress)
        {
            case (0):
                Pilesr.sprite = Pile0;
                break;
            case (1):
                Pilesr.sprite = Pile1;
                break;
            case (2):
                Pilesr.sprite = Pile2;
                break;
            case (3):
                Pilesr.sprite = Pile3;
                break;
            case (4):
                Pilesr.sprite = Pile4;
                Win = 1;
                break;
            default:
                break;
        }

        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Curtain.GetComponent<DownFlag>().enabled = true;
            Curtain.GetComponent<PresentResults>().enabled = true;
            Pile.GetComponent<GameMoney>().enabled = false;
        }
        else
        {
            T = T - Time.deltaTime;
        }
    }
}
