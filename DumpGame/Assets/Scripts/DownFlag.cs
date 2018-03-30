using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DownFlag : MonoBehaviour
{
    public float Length, Iteration;
    public GameObject Curtain, TimeText, ScoreText, LivesText, RuleText;
    public SpriteRenderer CurtainSR;

    void Start()
    {
        Length = 16f;
        Iteration = -0.50f;
        CurtainSR = Curtain.GetComponent<SpriteRenderer>();
        CurtainSR.enabled = true;
    }

    void Update()
    {
        if (Length > 0)
        {
            transform.Translate(0, Iteration, 0);
            Length += Iteration;
        }
        else
        {
            TimeText.GetComponent<Text>().enabled = true;
            ScoreText.GetComponent<Text>().enabled = true;
            LivesText.GetComponent<Text>().enabled = true;
            RuleText.GetComponent<Text>().enabled = true;
            Curtain.GetComponent<DownFlag>().enabled = false;
        }
    }
}
