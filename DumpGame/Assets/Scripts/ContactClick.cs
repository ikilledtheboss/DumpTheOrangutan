using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactClick : MonoBehaviour
{
    public bool hold;

    void start()
    {
        hold = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("WinSpace"))
            hold = true;
        else
            hold = false;
    }
}
