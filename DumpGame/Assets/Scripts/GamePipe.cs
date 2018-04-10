using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePipe : MonoBehaviour {


    public GameObject Pipe1, Pipe2, Pipe3, Line, Curtain, ScoreKeeper;
    public int Win, P1, P2, P3;
    public float T, x1, x2, x3;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;

    void Start()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Win = 0;
        P1 = Pipe1.GetComponent<ClickDragItem>().Drag;
        P2 = Pipe2.GetComponent<ClickDragItem>().Drag;
        P3 = Pipe3.GetComponent<ClickDragItem>().Drag;
        Pipe2.GetComponent<BoxCollider2D>().enabled = false;
        Pipe3.GetComponent<BoxCollider2D>().enabled = false;
        T = PlayerPrefs.GetFloat("PTime");
        Curtain.GetComponent<UpFlag>().enabled = true;
        tt = T;
    }
    // Update is called once per frame
    void Update()
    {
        if (P1 == 2)
        {
            x1 = Pipe1.transform.position.x;
            if (x1 >= 0 && x1 <= 2)
            {
                P1++;
                Pipe2.GetComponent<BoxCollider2D>().enabled = true;
                Pipe1.GetComponent<ClickDragItem>().enabled = false;
            }
            else
                Pipe1.GetComponent<ClickDragItem>().Drag = 0;
        }
        else if (P1 != 3)
            P1 = Pipe1.GetComponent<ClickDragItem>().Drag;

        if (P2 == 2)
        {
            x2 = Pipe2.transform.position.x;
            if (x2 >= 0 && x2 <= 2)
            {
                P2++;
                Pipe3.GetComponent<BoxCollider2D>().enabled = true;
                Pipe2.GetComponent<ClickDragItem>().enabled = false;
            }
            else
                Pipe2.GetComponent<ClickDragItem>().Drag = 0;
        }
        else if (P2 != 3)
            P2 = Pipe1.GetComponent<ClickDragItem>().Drag;

        if (P3 == 2)
        {
            x3 = Pipe3.transform.position.x;
            if (x3 >= 0 && x3 <= 2)
            {
                Win = 1;
                P3++;
                Pipe3.GetComponent<ClickDragItem>().enabled = false;
            }
            else
                Pipe3.GetComponent<ClickDragItem>().Drag = 0;
        }
        else if (P3 != 3)
            P3 = Pipe3.GetComponent<ClickDragItem>().Drag;


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
