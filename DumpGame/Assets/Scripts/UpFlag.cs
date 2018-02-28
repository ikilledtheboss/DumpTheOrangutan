using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpFlag : MonoBehaviour
{
    float a, b;

    // Use this for initialization
    void Start()
    {
        a = 14f;
        b = 0.40f;
    }

    // Update is called once per frame
    void Update()
    {
        if (a > 0)
        {
            transform.Translate(0, b, 0);
            a -= b;
        }
        else
        {
            this.enabled = false;
        }
    }
}
