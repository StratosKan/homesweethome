using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveEnable : MonoBehaviour {

    public GameObject obj;
    DisableInteraction inter;
    public bool toCheck;
    float timer;

	// Use this for initialization
	void Start ()
    {
        inter = GetComponent<DisableInteraction>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (inter.hasInteracted)
        {
            timer += Time.deltaTime;
            if (timer >= Random.Range(10, 25))
            {
                obj.GetComponent<SoundClipsScene2>().talkAboutBoiler = true;
            }
        }
	}
}
