using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpFlag : MonoBehaviour
{
    float Length, Iteration;
    public GameObject Curtain;
    public SpriteRenderer CurtainSR;

    void Start()
    {
        Length = 16f;
        Iteration = 0.50f;
        CurtainSR = Curtain.GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if (Length > 0)
        {
            transform.Translate(0, Iteration, 0);
            Length -= Iteration;
        }
        else
        {
            CurtainSR.enabled = false;
            this.enabled = false;
        }
    }
}
