using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WifeDialogue : MonoBehaviour {

    public AudioSource source;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        source.Play();
        other.GetComponentInChildren<SoundClips>().wifeTalked = true;
        Destroy(this.gameObject);
    }
}
