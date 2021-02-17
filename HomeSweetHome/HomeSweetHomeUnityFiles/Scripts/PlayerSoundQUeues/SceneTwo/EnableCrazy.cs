using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCrazy : MonoBehaviour {

    // Use this for initialization
    public GameObject obj;
    DisableInteraction inter;
    public bool toCheck;
    float timer;
    // Use this for initialization
    void Start()
    {
        inter = GetComponent<DisableInteraction>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inter.hasInteracted)
        {
            timer += Time.deltaTime;
            if (timer >= 1.5)
            {
                obj.GetComponent<SoundClipsScene2>().talkAboutCrazy = true;
            }
            if (timer >= Random.Range(16, 24))
            {
                if (!obj.GetComponent<AudioSource>().isPlaying)
                {
                    obj.GetComponent<SoundClipsScene2>().talkAboutLoop = true;
                }
            }
        }
    }
}
