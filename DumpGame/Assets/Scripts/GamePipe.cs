using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePipe : MonoBehaviour {


    public GameObject Pipe1, Pipe2, Pipe3, Pipe4, r1, r2, r3, r4, b1, b2, b3, b4, d1, d2, d3 ,d4, Dump1, Dump2, pipe, Line, Curtain, ScoreKeeper;
    public int Win;
    public Sprite s;
    public bool P1, P2, P3, P4, pp1, pp2, pp3, pp4;
    public float T, x1, x2, x3, reset;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;

    void Start()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Win = 0;
        reset = -1;
        P1 = Pipe1.GetComponent<ContactClick>().hold;
        P2 = Pipe2.GetComponent<ContactClick>().hold;
        P3 = Pipe3.GetComponent<ContactClick>().hold;
        P4 = Pipe4.GetComponent<ContactClick>().hold;
        pp1 = true;
        pp2 = true;
        pp3 = true;
        pp4 = true;
        Pipe2.GetComponent<BoxCollider2D>().enabled = false;
        Pipe3.GetComponent<BoxCollider2D>().enabled = false;
        Pipe4.GetComponent<BoxCollider2D>().enabled = false;
        T = 4.5f;
//CHANGE
        Curtain.GetComponent<UpFlag>().enabled = true;
        tt = T;
    }
    // Update is called once per frame
    void Update()
    {
        P1 = Pipe1.GetComponent<ContactClick>().hold;
        P2 = Pipe2.GetComponent<ContactClick>().hold;
        P3 = Pipe3.GetComponent<ContactClick>().hold;
        P4 = Pipe4.GetComponent<ContactClick>().hold;
        if (P1 == true && pp1 == true)
        {
            reset = 0.4f;
            Dump1.GetComponent<SpriteRenderer>().enabled = false;
            Dump2.GetComponent<SpriteRenderer>().enabled = true;
            pipe.GetComponent<SpriteRenderer>().enabled = true;
            Pipe1.GetComponent<SpriteRenderer>().enabled = false;
            Pipe1.GetComponent<BoxCollider2D>().enabled = false;
            Pipe2.GetComponent<BoxCollider2D>().enabled = true;
            pp1 = false;
            r1.GetComponent<SpriteRenderer>().enabled = true;
            b1.SetActive(false);
            b2.SetActive(true);
            d1.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (P2 == true && pp2 == true)
        {
            reset = 0.4f;
            Dump1.GetComponent<SpriteRenderer>().enabled = false;
            Dump2.GetComponent<SpriteRenderer>().enabled = true;
            pipe.GetComponent<SpriteRenderer>().enabled = true;
            Pipe2.GetComponent<SpriteRenderer>().enabled = false;
            Pipe2.GetComponent<BoxCollider2D>().enabled = false;
            Pipe3.GetComponent<BoxCollider2D>().enabled = true;
            r2.GetComponent<SpriteRenderer>().enabled = true;
            pp2 = false;
            b2.SetActive(false);
            b3.SetActive(true);
            d2.GetComponent<SpriteRenderer>().enabled = true;

        }

        if (P3 == true && pp3 == true)
        {
            reset = 0.4f;
            Dump1.GetComponent<SpriteRenderer>().enabled = false;
            Dump2.GetComponent<SpriteRenderer>().enabled = true;
            pipe.GetComponent<SpriteRenderer>().enabled = true;
            Pipe3.GetComponent<BoxCollider2D>().enabled = false;
            Pipe3.GetComponent<SpriteRenderer>().enabled = false;
            Pipe4.GetComponent<BoxCollider2D>().enabled = true;
            r3.GetComponent<SpriteRenderer>().enabled = true;
            pp3 = false;
            b3.SetActive(false);
            b4.SetActive(true);
            d3.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (P4 == true && pp4 == true)
        {
            reset = 0.4f;
            Dump1.GetComponent<SpriteRenderer>().enabled = false;
            Dump2.GetComponent<SpriteRenderer>().enabled = true;
            pipe.GetComponent<SpriteRenderer>().enabled = true;
            Pipe4.GetComponent<SpriteRenderer>().enabled = false;
            Pipe4.GetComponent<BoxCollider2D>().enabled = false;
            Win = 1;
            pp4 = false;
            r4.GetComponent<SpriteRenderer>().enabled = true;
            b4.SetActive(false);
            d4.GetComponent<SpriteRenderer>().enabled = true;
        }

        if (reset < 0)
        {
            Dump2.GetComponent<SpriteRenderer>().enabled = false;
            pipe.GetComponent<SpriteRenderer>().enabled = false;
            Dump1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
            reset = reset - Time.deltaTime;

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
