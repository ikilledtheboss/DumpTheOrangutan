using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimelineVote : MonoBehaviour
{
    public List<PlayableDirector> playableDirectors;
    public List<PlayableDirector> stopableDirectors;
    public List<TimelineAsset> timelines;
    public bool a = false;
    public GameObject Button1, Button2, Button3;
    public PlayableDirector pd;

    public void Play()
    {
        Button2.SetActive(false);
        foreach (PlayableDirector playableDirector in playableDirectors)
        {
            playableDirector.Play();
            pd = playableDirector;
        }
    }

    public void Pause()
    {
        foreach (PlayableDirector stopableDirector in stopableDirectors)
        {
            a = true;
            stopableDirector.Pause();
        }
    }
    void Update()
    {
        if(pd.time > 23)
        {
            Button1.SetActive(true);
            Button3.SetActive(false);
        }
    }
    public void PlayFromTimelines(int index)
    {
        TimelineAsset selectedAsset;

        if (timelines.Count <= index)
        {
            selectedAsset = timelines[timelines.Count - 1];
        }
        else
        {
            selectedAsset = timelines[index];
        }
        playableDirectors[0].Play(selectedAsset);
    }


}
