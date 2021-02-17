using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyAfterMath : MonoBehaviour
{
    DisableInteraction interaction;
    JitterAllLight jitter;
    AudioSource[] aud = new AudioSource[2];
    public AudioSource[] allSources;
    public GameObject knife;
    bool interactOnce = true;
	// Use this for initialization
	void Start () {
        interaction = GetComponent<DisableInteraction>();
        jitter = GetComponent<JitterAllLight>();
        aud = GetComponents<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (interaction.hasInteracted && interactOnce)
        {
            jitter.jitterAll = true;
            aud[1].Play();
            foreach (AudioSource item in allSources)
            {
               item.enabled = true;
                item.volume = 1;
            }
            knife.SetActive(true);
            interactOnce = false;
        }
	}
}
