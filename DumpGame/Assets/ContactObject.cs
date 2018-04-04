using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactObject : MonoBehaviour
{
    public bool mm, hold, win;
    private Rigidbody2D r;
    Collider2D ok;
    void start()
    {
        mm = false;
        hold = false;
        win = false;
        r = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        mm = true;
        ok = other;
        if (other.CompareTag("HoldSpace"))
        {
            hold = true;
        }
        if (other.CompareTag("WinSpace"))
            win = true;
    }
}
