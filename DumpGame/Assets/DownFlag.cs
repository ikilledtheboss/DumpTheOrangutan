using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownFlag : MonoBehaviour
{
    float c, d;

    // Use this for initialization
    void Start()
    {
        c = 14f;
        d = 0.10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (c > 0)
        {
            transform.Translate(0, -d, 0);
            c -= d;
        }
        else
        {
            this.enabled = false;
            //Return to menu with information.
        }
    }
}
