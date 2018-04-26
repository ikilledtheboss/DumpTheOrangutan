using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBuildWall : MonoBehaviour
{
    public GameObject Wall1, Wall2, Wall3, Wall4, Wall5, Button1, Button2, Button3, Store, Cloud1, Cloud2, Cloud3, Curtain;
    public Sprite store, ThirdWall;
    public int Progress, Win;
    public float T, Iteration;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;

    void Start ()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Button2.GetComponent<Button>().interactable = false;
        Button3.GetComponent<Button>().interactable = false;
        Progress = 1;
        Win = 0;
        T = PlayerPrefs.GetFloat("PTime");
        tt = T;
        Iteration = 0.03f;
    }
	
    public void FirstClick()
    {
        Progress=2;
        Wall1.GetComponent<Animator>().enabled = false;
        Wall1.GetComponent<SpriteRenderer>().enabled = false;
        Wall2.GetComponent<Animator>().enabled = true;
        Wall2.GetComponent<SpriteRenderer>().enabled = true;
        Button1.GetComponent<Button>().interactable = false;
        Button2.GetComponent<Button>().interactable = true;
    }

    public void SecondClick()
    {
        Progress = 3;
        Wall2.GetComponent<Animator>().enabled = false;
        Wall2.GetComponent<SpriteRenderer>().enabled = false;
        Wall3.GetComponent<Animator>().enabled = true;
        Wall3.GetComponent<SpriteRenderer>().enabled = true;
        Button2.GetComponent<Button>().interactable = false;
    }

    public void ThirdClick()
    {
        Win = 1;
        Progress = 5;
        Wall4.GetComponent<Animator>().enabled = false;
        Wall4.GetComponent<SpriteRenderer>().enabled = false;
        Wall5.GetComponent<SpriteRenderer>().enabled = true;
    }

    void Update()
    {
        if (Progress == 3)
        {
            store = Wall3.GetComponent<SpriteRenderer>().sprite;
            if (store == ThirdWall)
            {
                Progress = 4;
                Wall3.GetComponent<Animator>().enabled = false;
                Wall3.GetComponent<SpriteRenderer>().enabled = false;
                Wall4.GetComponent<Animator>().enabled = true;
                Wall4.GetComponent<SpriteRenderer>().enabled = true;
                Button3.GetComponent<Button>().interactable = true;
            }
        }
        Cloud1.transform.Translate(Iteration, 0, 0);
        Cloud2.transform.Translate(-Iteration, 0, 0);
        Cloud3.transform.Translate(Iteration, 0, 0);

        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            Store.GetComponent<PresentResults>().enabled = true;
            Store.GetComponent<GameBuildWall>().enabled = false;
        }
        else
        {
            T = T - Time.deltaTime;
        }
    }
}
