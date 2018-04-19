using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePipe : MonoBehaviour {


    public GameObject Pipe1, Pipe2, Pipe3, Pipe4, r1, r2, r3, r4, b1, b2, b3, b4, d1, d2, d3 ,d4, Dump1, Dump2, Line, Curtain, ScoreKeeper;
    public int Win;
    public Sprite s;
    public bool P1, P2, P3,P4;
    public float T, x1, x2, x3;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;

    void Start()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Win = 0;
        P1 = Pipe1.GetComponent<ContactPipe>().hold;
        P2 = Pipe2.GetComponent<ContactPipe>().hold;
        P3 = Pipe3.GetComponent<ContactPipe>().hold;
        P4 = Pipe4.GetComponent<ContactPipe>().hold;
        Pipe2.GetComponent<BoxCollider2D>().enabled = false;
        Pipe3.GetComponent<BoxCollider2D>().enabled = false;
        Pipe4.GetComponent<BoxCollider2D>().enabled = false;
        T = PlayerPrefs.GetFloat("PTime");
        //if(T <= 3.5)
        //{
        //    P1 = true;
        //}
        Curtain.GetComponent<UpFlag>().enabled = true;
        tt = T;
    }
    // Update is called once per frame
    void Update()
    {

        P1 = Pipe1.GetComponent<ContactPipe>().hold;
        P2 = Pipe2.GetComponent<ContactPipe>().hold;
        P3 = Pipe3.GetComponent<ContactPipe>().hold;
        P4 = Pipe4.GetComponent<ContactPipe>().hold;
        if (P1 == true)
        {
            Dump1.GetComponent<SpriteRenderer>().enabled = false;
            Dump2.GetComponent<SpriteRenderer>().enabled = true;
            Dump1.GetComponent<Animator>().enabled = false;
            Dump2.GetComponent<Animator>().enabled = true;
            Pipe1.GetComponent<SpriteRenderer>().enabled = false;
            Pipe1.GetComponent<BoxCollider2D>().enabled = false;
            Pipe2.GetComponent<BoxCollider2D>().enabled = true;
            r1.GetComponent<SpriteRenderer>().enabled = true;
            b1.SetActive(false);
            b2.SetActive(true);
            d1.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (P2 == true)
        {
            Dump1.GetComponent<SpriteRenderer>().enabled = false;
            Dump2.GetComponent<SpriteRenderer>().enabled = true;
            Dump1.GetComponent<Animator>().enabled = false;
            Dump2.GetComponent<Animator>().enabled = true;
            Pipe2.GetComponent<SpriteRenderer>().enabled = false;
            Pipe2.GetComponent<BoxCollider2D>().enabled = false;
            Pipe3.GetComponent<BoxCollider2D>().enabled = true;
            r2.GetComponent<SpriteRenderer>().enabled = true;
            b2.SetActive(false);
            b3.SetActive(true);
            d2.GetComponent<SpriteRenderer>().enabled = true;

        }

        if (P3 == true)
        {
            Dump1.GetComponent<SpriteRenderer>().enabled = false;
            Dump2.GetComponent<SpriteRenderer>().enabled = true;
            Dump1.GetComponent<Animator>().enabled = false;
            Dump2.GetComponent<Animator>().enabled = true;
            Pipe3.GetComponent<BoxCollider2D>().enabled = false;
            Pipe3.GetComponent<SpriteRenderer>().enabled = false;
            Pipe4.GetComponent<BoxCollider2D>().enabled = true;
            r3.GetComponent<SpriteRenderer>().enabled = true;
            b3.SetActive(false);
            b4.SetActive(true);
            d3.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (P4 == true)
        {
            Dump1.GetComponent<SpriteRenderer>().enabled = false;
            Dump2.GetComponent<SpriteRenderer>().enabled = true;
            Dump1.GetComponent<Animator>().enabled = false;
            Dump2.GetComponent<Animator>().enabled = true;
            Pipe4.GetComponent<SpriteRenderer>().enabled = false;
            Pipe4.GetComponent<BoxCollider2D>().enabled = false;
            Win = 1;
            r4.GetComponent<SpriteRenderer>().enabled = true;
            b4.SetActive(false);
            d4.GetComponent<SpriteRenderer>().enabled = true;
        }

        if(Dump2.GetComponent<SpriteRenderer>().sprite == s)
        {
            Dump2.GetComponent<SpriteRenderer>().enabled = false;
            Dump1.GetComponent<SpriteRenderer>().enabled = true;
            Dump2.GetComponent<Animator>().enabled = false;
            Dump1.GetComponent<Animator>().enabled = true;
        }

        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Curtain.GetComponent<DownFlag>().enabled = true;
            Curtain.GetComponent<PresentResults>().enabled = true;
            Line.GetComponent<GamePipe>().enabled = false;
        }
        else
        {
            T = T - Time.deltaTime;
        }
    }
}
