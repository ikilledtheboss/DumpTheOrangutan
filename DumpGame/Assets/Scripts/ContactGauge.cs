using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactGauge : MonoBehaviour
{ 
    public bool Winner;
    Collider2D ok;

    void start()
    {
        Winner = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("WinSpace"))
            Winner = true;
        if (other.CompareTag("BadSpace"))
            Winner = false;
    }
}
