using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueTracker : MonoBehaviour {

    public int Score, Lives, Time;
    public bool win;

	void Start ()
    {
	    Score = -1;
        Lives = 3;
        Time = 7;
        win = true;	
	}
	
    void SpeedUp()
    {
        Time--;
    }

    void ScoreUp()
    {
        Score++;
    }

    void LivesDown()
    {
        Lives--;
    }
}
