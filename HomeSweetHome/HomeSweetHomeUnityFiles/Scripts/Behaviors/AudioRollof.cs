using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRollof : MonoBehaviour, IInteractable
{
    AudioSource aud;
    private bool _canInteract=false;
    public float speedOfDiable = 2;
    public void Start()
    {
        aud = GetComponent<AudioSource>();
    }
    public void Interact()
    {
        _canInteract = true;
    }
    public void Update()
    {
        if (_canInteract)
        {
            aud.pitch -= Time.deltaTime /speedOfDiable;
            aud.volume -= Time.deltaTime/speedOfDiable;
        }
        if (aud.pitch <= 0)
        {
            aud.enabled = false;
        }

    }
}
