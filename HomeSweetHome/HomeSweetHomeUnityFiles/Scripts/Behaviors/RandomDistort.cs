using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioDistortionFilter))]
[RequireComponent(typeof(AudioEchoFilter))]
public class RandomDistort : MonoBehaviour,IInteractable

{

    
    AudioSource aud;
    AudioEchoFilter echo;
    AudioDistortionFilter dist;
    public bool _canInteract = false;
    float timer = 0;
    public float timeToDistort =1;
    public void Interact()
    {
        _canInteract = true;
    }

    // Use this for initialization
    void Start ()
    {
        aud = GetComponent<AudioSource>();
        echo = GetComponent<AudioEchoFilter>();
        dist = GetComponent<AudioDistortionFilter>();
        dist.distortionLevel = 0;

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (_canInteract)
        {
            echo.delay = 56;
            echo.decayRatio = 0.95f;
            dist.distortionLevel += Time.deltaTime;
            aud.volume -= Time.deltaTime;
            if (aud.volume <= 0.6f)
            {
                aud.volume = 0.6f;
            }
            if (dist.distortionLevel >= 0.95f)
            {
                dist.distortionLevel = 0.95f;
            }
            timer += Time.deltaTime;
        }
        if (timer >= timeToDistort)
        {
            aud.Stop();
        }


    }
}
