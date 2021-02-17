using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnEvent : MonoBehaviour, IEventable
{

    public AudioSource source;
    float timeToWaitForEvent = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
   
    public IEnumerator TimeBeforEvent()
    {
        yield return new WaitForSeconds(timeToWaitForEvent);
        EventTime();
    }

    public void EventTime()
    {
        if (!source.isPlaying)
        {
            source.PlayOneShot(source.clip);
        }
    }
}
