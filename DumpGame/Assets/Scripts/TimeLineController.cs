using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class TimeLineController : MonoBehaviour
{
    public List<PlayableDirector> playableDirectors;
    public List<PlayableDirector> stopableDirectors;
    public List<TimelineAsset> timelines;
    public  bool a = false;
    public void Play()
    {
        foreach (PlayableDirector playableDirector in playableDirectors)
        {
            playableDirector.Play();
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

    public void PlayFromTimelines(int index)
    {
        TimelineAsset selectedAsset;

        if(timelines.Count <= index)
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
