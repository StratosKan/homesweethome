using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableBaby : MonoBehaviour {

    public GameObject obj;
    DisableInteraction inter;
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
            if (timer >= Random.Range(8, 12))
            {
                obj.GetComponent<SoundClipsScene2>().talkAboutBaby = true;
            }
        }
    }
}
