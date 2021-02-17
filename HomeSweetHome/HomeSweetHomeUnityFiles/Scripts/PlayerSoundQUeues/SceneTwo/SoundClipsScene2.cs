using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundClipsScene2 : MonoBehaviour {

    public AudioClip[] clips;
    AudioSource source;
    public bool talkAboutBoiler=false;
    public bool talkAboutBaby = false;
    public bool talkAboutCrazy = false;
    public bool talkAboutLoop = false;
    bool clockPlayed = false;
    bool playOnce = false;
    bool babyOnce = false;
    bool lightsOnce = false;
    float timer = 0;
    int counter = 4;
    float loopTimer = 0;
	// Use this for initialization
	void Start ()
    {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Clock();
        Boiler();
        Baby();
        Lights();
        Loop();
	}
    void Clock()
    {
        timer += Time.deltaTime;
        if (timer >= 3)
        {
            if (!clockPlayed)
            {
                source.PlayOneShot(clips[0]);
                clockPlayed = true;
            }
        }
            
    }
    void Boiler()
    {
        if (talkAboutBoiler)
        {
            if (!playOnce)
            {
                source.PlayOneShot(clips[1]);
                playOnce = true;
            }
        }
    }
    void Baby()
    {
        if (talkAboutBaby)
        {
            if (!babyOnce)
            {
                source.PlayOneShot(clips[2]);
                babyOnce = true;
            }
        }
    }
    void Lights()
    {

        if (talkAboutCrazy)
        {
            if (!lightsOnce)
            {
                source.PlayOneShot(clips[3]);
                lightsOnce = true;
            }
        }
    }
    void Loop()
    {
        if (talkAboutLoop)
        {
            loopTimer += Time.deltaTime;
            if (loopTimer >= Random.Range(20,40))
            {
                if (!source.isPlaying)
                {
                    source.PlayOneShot(clips[Random.Range(4, 7)]);
                }
                loopTimer = 0;
            }
        }
    }
}
