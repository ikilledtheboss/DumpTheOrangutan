using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainLeft : MonoBehaviour {

    
    float a, b;

	// Use this for initialization
	void Start ()
    {
        a = 13f;
        b = -0.2f;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (a > 0)
        {
            transform.Translate(b, 0, 0);
            a -= b;
        }	
        else
        {
            this.enabled =false;
        }
	}
}
