using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOtherObject : MonoBehaviour {

    public Collider objectToActivate;
    DisableInteraction interaction;
    float timer = 0;
	// Use this for initialization
	void Start ()
    {
        interaction = GetComponent<DisableInteraction>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (interaction.hasInteracted)
        {
            objectToActivate.enabled = true;
            if (objectToActivate.GetComponent<AudioSource>() != null)
            {
                if (!objectToActivate.GetComponent<AudioSource>().isPlaying)
                {
                    timer += Time.deltaTime;
                    if (timer > Random.Range(3, 8))
                    {
                        objectToActivate.GetComponent<AudioSource>().Play();
                    }
                }
            }
        }
	}
}
