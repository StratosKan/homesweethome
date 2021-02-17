using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllLights : MonoBehaviour,IInteractable
{
    GameObject[] objects;
    Light[] lights;
    public bool lightsOff=false;
    public void Interact()
    {
        objects = GameObject.FindGameObjectsWithTag("Light");
        lights = new Light[objects.Length ];
        for (int i=0;i<lights.Length;i++)
        {
            lights[i] = objects[i].GetComponent<Light>();
        }
        foreach (Light x in lights)
        {
            x.enabled = false;
        }
    }
    void Update()
    {
        if (lightsOff)
        {
            Interact();
        }
    }
}
