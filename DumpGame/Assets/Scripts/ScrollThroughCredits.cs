using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScrollThroughCredits : MonoBehaviour
{
    public float Length, Iteration;
    public bool stalled;
    public GameObject Current;
    void Start ()
    {
        Length = 60f;
        stalled = false;
        Iteration = 0.06f;
	}
	
	void Update ()
    {
        if(stalled == false)
        {
            transform.Translate(0, Iteration, 0);
            Length -= Iteration;
            if (Length <= 0)
            {
                Current.SetActive(false);
            }
        }
    }

    public void Pausing()
    {
        if (stalled == false)
        {
            stalled = true;
        }
        else
            stalled = false;
    }
}
