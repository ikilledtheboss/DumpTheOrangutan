using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimeLineKeys : MonoBehaviour
{
    public List<PlayableDirector> playableDirectors;
    public List<PlayableDirector> stopableDirectors;
    public GameObject Keys, Button, Curtain;

     void Update()
    {
        if (Curtain.GetComponent<UpFlag>().enabled == false)
        {
            playableDirectors[1].Play();
        }
    }

    public void Play()
    {
        if (Keys.GetComponent<ContactGauge>().Winner == true)
        {
            playableDirectors[0].Play();
            stopableDirectors[0].Pause();
            Button.GetComponent<GameKeys>().Win = 1;
        }
        else
        {
            Button.GetComponent<GameKeys>().Win = 0;
        }
    }
}
