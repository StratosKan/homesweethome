using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour,IInteractable
{
    public Light light;
    public bool isOn;
    public void Interact()
    {
        isOn = !isOn;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isOn)
        {
            light.enabled = true;
        }
        else
        {
            light.enabled = false;
        }
	}
}
