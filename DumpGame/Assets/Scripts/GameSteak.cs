using System;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSteak : MonoBehaviour
{

	public GameObject Steak, Ketchup, Curtain, ScoreKeeper;
	public int Win, kval;
	public int collideCounter = 0; 
	public float T, y1, x1;
	public Text ScoreText, LivesText, RuleText, TimeText;
	public double tt;

	void Start ()
	{
		ScoreText.enabled = false;
		LivesText.enabled = false;
		RuleText.enabled = false;
		Win = 0;
		kval = Ketchup.GetComponent<ClickDragItem>().Drag;
		T = 6;
		Curtain.GetComponent<UpFlag>().enabled = true;
		tt = T;
	}

	void Update ()
	{
        if (collideCounter == 10)
        {
            Win = 1;
        }

        if (T < 0)
		{
			PlayerPrefs.SetInt("Result", Win);
			Curtain.GetComponent<DownFlag>().enabled = true;
			Curtain.GetComponent<PresentResults>().enabled = true;
		    Steak.GetComponent<GameSteak>().enabled = false;
		}
		else
		{
			T = T - Time.deltaTime;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "collide") 
		{
			collideCounter++;
		}
	}

	public void AddCounter(){
		++collideCounter;
	}
}
