using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimeLineChoice : MonoBehaviour
{
    public List<PlayableDirector> playableDirectors;
    public GameObject Ball, Button, Curtain;
    public bool beginning;

    void Start()
    {
        beginning = false;
    }
    void Update()
    {
        if (Curtain.GetComponent<UpFlag>().enabled == false && beginning == false)
        {
            playableDirectors[2].Play();
            beginning = true;
        }
    }

    public void Play()
    {
        if(Ball.GetComponent<ContactGauge>().Winner == true)
        {
            playableDirectors[0].Play();
            Button.GetComponent<GolfGameplay>().Win = 1;
        }
        else
        {
            playableDirectors[1].Play();
            Button.GetComponent<GolfGameplay>().Win = 0;
        }
    }
}
