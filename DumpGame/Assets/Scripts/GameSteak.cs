using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class GameSteak : MonoBehaviour
{
    public GameObject self, Blurp, Curtain;
    public int Win, tttt;
    public int collideCounter;
    public float T;
    public Text ScoreText, LivesText, RuleText, TimeText;
    public double tt;
    public PlayableDirector Ketchup;

    void Start()
    {
        ScoreText.enabled = false;
        LivesText.enabled = false;
        RuleText.enabled = false;
        Win = 0;
        T = PlayerPrefs.GetFloat("PTime");
        tt = T;
    }

    void Update()
    {
        if(collideCounter == 10)
        {
            collideCounter++;
            Blurp.GetComponent<SpriteRenderer>().enabled = true;
            Player();
            Win = 1;
        }

        if(T < 0)
        {
            PlayerPrefs.SetInt("Result", Win);
            self.GetComponent<PresentResults>().enabled = true;
            self.GetComponent<GameSteak>().enabled = false;
        }

        else
        {
            T = T - Time.deltaTime;
        }
    }
    
    void Player()
    {
        tttt = 12;
        Ketchup.Play(); 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "collide")
        {
            collideCounter++;
        }
    }

    public void AddCounter()
    {
        ++collideCounter;
    }
}
