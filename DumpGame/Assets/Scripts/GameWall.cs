using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameWall : MonoBehaviour
{
    public GameObject Piece1,Piece2,Piece3,Piece4, Back, Curtain;
    public Sprite FixWall, CrumbleWall;
    public int Progress, Win;
    public bool p1, p2, p3, p4, fail;
    public float T;
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
        Curtain.GetComponent<UpFlag>().enabled = true;
        tt = T;
        p1 = Piece1.GetComponent<ClickItem>().Clicked;
        p2 = Piece2.GetComponent<ClickItem>().Clicked;
        p3 = Piece3.GetComponent<ClickItem>().Clicked;
        p4 = Piece4.GetComponent<ClickItem>().Clicked;
        fail = Back.GetComponent<ClickItem>().Clicked;
    }
    
    void Update()
    {
        if (fail == true)
        {
            Piece1.GetComponent<SpriteRenderer>().sprite = CrumbleWall;
            Piece2.GetComponent<SpriteRenderer>().sprite = CrumbleWall;
            Piece3.GetComponent<SpriteRenderer>().sprite = CrumbleWall;
            Piece4.GetComponent<SpriteRenderer>().sprite = CrumbleWall;
            Win = 0;
        }

        else if (p1 == true && p2 == true && p3 == true && p4 == true)
        {
            Piece1.GetComponent<SpriteRenderer>().sprite = FixWall;
            Piece2.GetComponent<SpriteRenderer>().sprite = FixWall;
            Piece3.GetComponent<SpriteRenderer>().sprite = FixWall;
            Piece4.GetComponent<SpriteRenderer>().sprite = FixWall;
            Win = 1;
        }

        else
        {
            if(p1 == true)
            {
                Piece1.GetComponent<SpriteRenderer>().sprite = FixWall;
            }
            if (p2 == true)
            {
                Piece2.GetComponent<SpriteRenderer>().sprite = FixWall;
            }
            if (p3 == true)
            {
                Piece3.GetComponent<SpriteRenderer>().sprite = FixWall;
            }
            if (p4 == true)
            {
                Piece4.GetComponent<SpriteRenderer>().sprite = FixWall;
            }
            p1 = Piece1.GetComponent<ClickItem>().Clicked;
            p2 = Piece2.GetComponent<ClickItem>().Clicked;
            p3 = Piece3.GetComponent<ClickItem>().Clicked;
            p4 = Piece4.GetComponent<ClickItem>().Clicked;
            fail = Back.GetComponent<ClickItem>().Clicked;
        }

        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Curtain.GetComponent<DownFlag>().enabled = true;
            Curtain.GetComponent<PresentResults>().enabled = true;
            Back.GetComponent<GameWall>().enabled = false;
        }
        else
        {
            T = T - Time.deltaTime;
        }

    }
}
