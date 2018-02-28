using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public Text Count;
    public float T;

	void Start ()
    {
        T = 6;
        Count = GetComponent<Text>();
	}
	
	void Update ()
    {

        if (T < 0)
        {
            Count.text = 0 + " Seconds Left";
        }
        else
        {
            T = T - Time.deltaTime;
            Count.text = T.ToString() + " Seconds Left";
        }
	}
}
