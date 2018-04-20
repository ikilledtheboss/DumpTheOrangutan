using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactPipe : MonoBehaviour
{
    public bool hold;
    void start()
    {
        hold = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("WinSpace"))
        {
            hold = true;
        }
    }
}
