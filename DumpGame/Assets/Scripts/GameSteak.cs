//using System;
//
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;
//
//public class GameSteak : MonoBehaviour
//{
//
//	public GameObject Ketchup, ColliderT, ColliderB, ColliderR, ColliderL, Curtain, ScoreKeeper;
//	//public SpriteRenderer Pilesr;
//	//public Sprite Pile0, Pile1, Pile2, Pile3, Pile4;
//	public int Progress, Win, kval;
//	public float T, y1, x1;
//	public Text ScoreText, LivesText, RuleText, TimeText;
//	public double tt;
//
//	void Start ()
//	{
//		ScoreText.enabled = false;
//		LivesText.enabled = false;
//		RuleText.enabled = false;
//		Progress = 0;
//		Win = 0;
//		//Pilesr = Pile.GetComponent<SpriteRenderer>();
//		kval = Ketchup.GetComponent<ClickDragItem>().Drag;
//		T = PlayerPrefs.GetFloat("PTime");
//		Curtain.GetComponent<UpFlag>().enabled = true;
//		tt = T;
//	}
//
//	void Update ()
//	{
//		if (M1 == 2)
//		{
//			y1 = Money1.transform.position.y;
//			if (y1 >= 0)
//			{
//				Progress=4;
//				M1++;
//				Money1.GetComponent<ClickDragItem>().enabled = false;
//				Money1.GetComponent<SpriteRenderer>().enabled = false;
//			}
//			else
//			{
//				//       Money1.transform.position = Money1.GetComponent<ClickDragItem>().StartLoc;
//				Money1.GetComponent<ClickDragItem>().Drag = 0;
//			}
//		}
//	
//		switch (Progress)
//		{
//		case (0):
//			Pilesr.sprite = Pile0;
//			break;
//		case (1):
//			Pilesr.sprite = Pile1;
//			break;
//		case (2):
//			Pilesr.sprite = Pile2;
//			break;
//		case (3):
//			Pilesr.sprite = Pile3;
//			Win = 1;
//			break;
//		case (4):
//			Pilesr.sprite = Pile4;
//			Win = 0;
//			break;
//		default:
//			break;
//		}
//
//		if (T < 0)
//		{
//			PlayerPrefs.SetInt("Result", Win);
//			Curtain.GetComponent<DownFlag>().enabled = true;
//			Curtain.GetComponent<PresentResults>().enabled = true;
//			Pile.GetComponent<GameMoney>().enabled = false;
//		}
//		else
//		{
//			T = T - Time.deltaTime;
//		}
//	}
//}
