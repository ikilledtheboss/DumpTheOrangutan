using UnityEngine.Playables;
using UnityEngine.Timeline;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TimeLineGrabCat : MonoBehaviour
{
	public List<PlayableDirector> playableDirectors;
	public List<PlayableDirector> stopableDirectors;
	public GameObject Woman, Button, Curtain;

	void Update()
	{
		if (Curtain.GetComponent<UpFlag>().enabled == false)
		{
			playableDirectors[1].Play();
		}
	}

	public void Play()
	{
		if (Woman.GetComponent<ContactGauge>().Winner == true)
		{
			playableDirectors[0].Play();
			stopableDirectors[0].Pause();
			Button.GetComponent<GameGrabWoman>().Win = 1;
		}
		else
		{
			Button.GetComponent<GameGrabWoman>().Win = 0;
		}
	}
}

