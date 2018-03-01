using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public Text Count;
    public float T;
    public int S;
    public double t;

	void Start ()
    {
        S = PlayerPrefs.GetInt("PScore");
        if(S < 4)
            T = 5;
        else if (S < 8)
            T = 4;
        else if (S < 12)
            T = 3;
        else
            T = 2;
        Count = GetComponent<Text>();
        t = Math.Floor(T);
	}
	
	void Update ()
    {

        if (T < 0)
        {
            Count.text = 0 + " Seconds Left";
        }
        else
        {
            if (T < t)
               t = Math.Floor(T);
            T = T - Time.deltaTime;
            Count.text = t.ToString() + " Seconds Left";
        }
	}
}
