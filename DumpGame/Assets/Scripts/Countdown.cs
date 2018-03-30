using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    public Text Count;
    public float T;
    public int S;
    public double tt;

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
        Count = this.GetComponent<Text>();
        tt = Math.Floor(T);
	}
	
	void Update ()
    {

        if (T < 0)
        {
            if (S < 4)
                T = 5;
            else if (S < 8)
                T = 4;
            else if (S < 12)
                T = 3;
            else
                T = 2;
        }
        else
        {
            if (T < tt)
               tt = Math.Floor(T);
            T = T - Time.deltaTime;
           Count.text = tt.ToString() + " Seconds Left";
        }
	}
}
