using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class GameComb : MonoBehaviour
{
    public GameObject self, Dump;
    public int Win;
    public int collideCounter;
    public float T;
    public double tt;
    public Sprite c1, c2, c3, c4, c5;

    void Start ()
    {
        Win = 0;
        T = PlayerPrefs.GetFloat("PTime");
        tt = T;
        collideCounter = 0;
	}

	void Update ()
    {
        Vector3 CurrentLoc = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 9f);
        Vector3 CurrentPos = Camera.main.ScreenToWorldPoint(CurrentLoc);
        transform.position = CurrentPos;
        if(collideCounter == 2)
        {
            Dump.GetComponent<SpriteRenderer>().sprite = c1;
        }
        else if (collideCounter == 4)
        {
            Dump.GetComponent<SpriteRenderer>().sprite = c2;
        }
        else if (collideCounter == 6)
        {
            Dump.GetComponent<SpriteRenderer>().sprite = c3;
        }
        else if (collideCounter == 8)
        {
            Dump.GetComponent<SpriteRenderer>().sprite = c4;
        }
        else if (collideCounter == 10)
        {
            Dump.GetComponent<SpriteRenderer>().sprite = c5;
            Win = 1;
        }

        if (T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            self.GetComponent<PresentResults>().enabled = true;
            self.GetComponent<GameComb>().enabled = false;
        }

        else
        {
            T = T - Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Comb")
        {
            collideCounter++;
        }
    }
}
