using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEnable : MonoBehaviour,IInteractable {

    public void Interact()
    {
        GetComponent<AudioSource>().enabled = false;
    }
}
