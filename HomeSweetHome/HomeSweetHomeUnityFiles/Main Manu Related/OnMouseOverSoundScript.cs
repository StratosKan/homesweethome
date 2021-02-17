using UnityEngine;

public class OnMouseOverSoundScript : MonoBehaviour
{
    public void MouseOverSound(AudioClip clip)
    {
        transform.parent.parent.GetComponents<AudioSource>()[0].PlayOneShot(clip); // this source has no effects
    }

    public void MouseClickSound(AudioClip clip)
    {
        transform.parent.parent.GetComponents<AudioSource>()[1].PlayOneShot(clip); // this source has echo
    }
}
