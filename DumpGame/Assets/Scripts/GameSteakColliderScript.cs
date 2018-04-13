using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSteakColliderScript : MonoBehaviour {
	public GameSteak GameSteakScript;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		print ("Collided");
		if(other.gameObject.tag=="SteakKetchup")
		{
			GameSteakScript.AddCounter();
		}

	}
}
