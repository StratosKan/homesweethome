using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JitterAllLight : MonoBehaviour
{
    GameObject[] objects;
    LightTremble[] lights;
    public bool jitterAll=false;
    public float timeToStopJitter;
    // Use this for initialization
    void Start ()
    {
        objects = GameObject.FindGameObjectsWithTag("Light");
        lights = new LightTremble[objects.Length];
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i] = objects[i].GetComponent<LightTremble>();
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (jitterAll)
        {
            StartCoroutine(Jitter());
          
        }
	}
    IEnumerator Jitter()
    {
        foreach (LightTremble x in lights)
        {
            x.jitterCooldown = Random.Range(1, 20);
            x.jitterDuration = Random.Range(1, 10);
        }
        jitterAll = false;
        yield return new WaitForSeconds(timeToStopJitter);
        foreach (LightTremble x in lights)
        {
            x.jitterCooldown = 0;
            x.jitterDuration = 0;
            x.hasRandom = false;
            x.timer = 0;
        }
    }
}
