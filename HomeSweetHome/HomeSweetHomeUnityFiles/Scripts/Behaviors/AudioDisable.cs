using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDisable : MonoBehaviour,IInteractable
{

    public void Interact()
    {
        GetComponent<AudioSource>().enabled = false;
    }
    void Start()
    {
    }

}
