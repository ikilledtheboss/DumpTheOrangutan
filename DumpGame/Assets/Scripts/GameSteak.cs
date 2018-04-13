using System;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSteak : MonoBehaviour
{

	public GameObject Steak, Ketchup, Curtain, ScoreKeeper;

	public int Progress, Win, kval;
	public int collideCounter = 0; 
	public float T, y1, x1;
	public Text ScoreText, LivesText, RuleText, TimeText;
	public double tt;

	void Start ()
	{
		ScoreText.enabled = false;
		LivesText.enabled = false;
		RuleText.enabled = false;
		Progress = 0;
		Win = 0;
		//Pilesr = Pile.GetComponent<SpriteRenderer>();
		kval = Ketchup.GetComponent<ClickDragItem>().Drag;
		T = PlayerPrefs.GetFloat("PTime");
		Curtain.GetComponent<UpFlag>().enabled = true;
		tt = T;
	}

	void Update ()
	{
		if (T < 0)
		{
			PlayerPrefs.SetInt("Result", Win);
			Curtain.GetComponent<DownFlag>().enabled = true;
			Curtain.GetComponent<PresentResults>().enabled = true;
			// Pile.GetComponent<GameMoney>().enabled = false;
		}
		else
		{
			T = T - Time.deltaTime;
		}

		if (collideCounter == 5) {
			print ("yo");
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
//		if (collideCounter == 5) {
//			print ("hey");
//		}
//
	}



}
