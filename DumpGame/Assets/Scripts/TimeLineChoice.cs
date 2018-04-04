using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimeLineChoice : MonoBehaviour
{
    public List<PlayableDirector> playableDirectors;
    public GameObject Ball, Button;

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
