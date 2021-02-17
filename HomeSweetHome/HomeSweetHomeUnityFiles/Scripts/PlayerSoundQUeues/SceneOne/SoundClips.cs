using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundClips : MonoBehaviour {

    public AudioClip[] clips;
    AudioSource source;
    public bool wifeTalked = false;
    bool noMoreTalking = false;
    public bool boilerDisabled = false;
    int counter = 2;
    float timer=0;
    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
        WokeUp();
    }

    // Update is called once per frame
    void Update()
    {
        Wife();
        VideoGames();
    }
    void WokeUp()
    {
        source.PlayOneShot(clips[0]);   // 0 is the Xasmourito clip.
    }
    void Wife()
    {
        if (wifeTalked)
        {
            if (!source.isPlaying)
            {
                if (!noMoreTalking)
                {
                    source.PlayOneShot(clips[1]);
                    noMoreTalking = true;
                }
            }
        }
    }
    void VideoGames()
    {
        if (boilerDisabled)
        {
            timer += Time.deltaTime;
            if (timer >=25)
            {
                if (!source.isPlaying)
                {
                    if (clips[counter + 1] != null)
                    {
                        source.PlayOneShot(clips[counter]);
                        counter++;
                    }
                    else
                    {
                        source.PlayOneShot(clips[counter]);
                    }
                }
                timer = 0;
            }
        }
    }
}
