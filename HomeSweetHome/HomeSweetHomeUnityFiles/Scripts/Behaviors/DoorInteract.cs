using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Behaviors;

public class DoorInteract : MonoBehaviour,IInteractable
{
    public Animator anim;
    public bool isOpen;
    public bool needsKey;
    public string keyName;
    private Inventory playerInv;
    private AnimatorStateInfo info;
    public bool canAnimate=true;
    public AudioSource doorSound;
    public void Awake()
    {
        doorSound = GameObject.Find("doorSound").GetComponent<AudioSource>();
        playerInv = GameObject.FindWithTag("Player").GetComponent<Inventory>();
        info = anim.GetCurrentAnimatorStateInfo(0);
    }

    public void Interact()
    {

        if (!needsKey)
        {
            if (canAnimate)
            {
                if (!isOpen)
                {
                    anim.SetTrigger("OpenDoor");
                    doorSound.Play();
                    //playAudio();
                }
                else if (isOpen)
                {
                    anim.SetTrigger("CloseDoor");
                    doorSound.Play();
                    //playAudio();
                }
                isOpen = !isOpen;
            }
        }
        else if (needsKey)
        {
            if (canAnimate)
            {
                if (keyName == playerInv.key1s && playerInv.key1) //checks if its the correct key and if the player has it in inventory
                {
                    if (!isOpen)
                    {
                        anim.SetTrigger("OpenDoor");
                        doorSound.Play();
                        //playAudio();
                    }
                    else if (isOpen)
                    {
                        anim.SetTrigger("CloseDoor");
                        doorSound.Play();
                        //playAudio();
                    }
                    isOpen = !isOpen;

                    playerInv.ShowUsedKey("Key01");
                }
                else if (keyName == playerInv.key2s && playerInv.key2)
                {
                    if (!isOpen)
                    {
                        anim.SetTrigger("OpenDoor");
                        doorSound.Play();
                    }
                    else if (isOpen)
                    {
                        anim.SetTrigger("CloseDoor");
                        doorSound.Play();
                    }
                    isOpen = !isOpen;

                    playerInv.ShowUsedKey("Key02");
                }
                else if (keyName == playerInv.key3s && playerInv.key3)
                {
                    if (!isOpen)
                    {
                        anim.SetTrigger("OpenDoor");
                        doorSound.Play();
                    }
                    else if (isOpen)
                    {
                        anim.SetTrigger("CloseDoor");
                        doorSound.Play();
                    }
                    isOpen = !isOpen;

                    playerInv.ShowUsedKey("Key03");
                }
                else
                {
                    if (!playerInv.GetComponentInChildren<AudioSource>().isPlaying)
                    {
                        playerInv.GetComponentInChildren<AudioSource>().PlayOneShot(playerInv.GetComponentInChildren<SoundClipsScene2>().clips[7]);
                    }
                }
            }
        }
    }
    void Update()
    {
        info = anim.GetCurrentAnimatorStateInfo(0);
        if (info.normalizedTime <= 1 && info.normalizedTime>0)
        {
            canAnimate = false;
        }
        else
        {
            canAnimate = true;
        }
        //Debug.Log(info.normalizedTime);
    }
}
