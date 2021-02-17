using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HOLYSHIT : MonoBehaviour {

    JitterAllLight lights;
    RandomDistort distort;
    public FadeScript fader;
    public GameObject obj;
	// Use this for initialization
	void Start ()
    {
        lights = GetComponent<JitterAllLight>();
        distort = GetComponent<RandomDistort>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (distort._canInteract)
        {
            lights.jitterAll = true;
            obj.SetActive(true);
            StartCoroutine(faderAfterEarbleed());
        }	
	}

    private IEnumerator faderAfterEarbleed()
    {
        yield return new WaitForSeconds(4f);
        fader.PlayAnimOut(2);
    }

}
