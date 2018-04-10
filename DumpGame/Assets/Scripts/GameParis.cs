using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameParis : MonoBehaviour
{

    public GameObject Pen, Curtain, ScoreKeeper;
    public int Progress, Win, Signature;
    public float T, x1, y1;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;

    void Start()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Progress = 0;
        Win = 0;
        Signature = Pen.GetComponent<ClickDragItem>().Drag;
        T = PlayerPrefs.GetFloat("PTime");
        Curtain.GetComponent<UpFlag>().enabled = true;
        tt = T;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Signature == 2)
        {
            x1 = Pen.transform.position.x;
            y1 = Pen.transform.position.y;
            if (x1 >= 1.5 && y1 <= 1 && y1 >=-0.5)
            {
                Win = 1;
                Pen.GetComponent<ClickDragItem>().enabled = false;
            }
            else
                Pen.GetComponent<ClickDragItem>().Drag = 0;
        }
        if(Win != 1)
            Signature = Pen.GetComponent<ClickDragItem>().Drag;

        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Curtain.GetComponent<DownFlag>().enabled = true;
            Curtain.GetComponent<PresentResults>().enabled = true;
            Pen.GetComponent<GameParis>().enabled = false;
        }
        else
        {
            T = T - Time.deltaTime;
        }
    }
}
