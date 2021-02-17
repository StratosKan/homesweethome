using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoilerDeactive : MonoBehaviour
{

    AudioSource source;
    DisableInteraction inter;
    public GameObject obj;
	// Use this for initialization
	void Start ()
    {
        source = GetComponent<AudioSource>();
        inter = GetComponent<DisableInteraction>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (inter.hasInteracted)
        {
            obj.GetComponent<SoundClips>().boilerDisabled = true;
        }
	}
}
