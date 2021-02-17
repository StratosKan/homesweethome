using System.Collections;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class EndgameScript : MonoBehaviour, IInteractable
{
    public GameObject blood;

    public AudioSource painSounds;
    public FadeScript blackOut;
    private GameObject player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Interact()
    {
        //picks up knife
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<RandomDistort>().Interact();
        //cuts ear

        painSounds.Play();
        blood.SetActive(true);
        Camera.main.gameObject.GetComponent<PostProcessingBehaviour>().enabled = true;

        StartCoroutine(afterCut());

    }

    private IEnumerator afterCut()
    {
        yield return new WaitForSeconds(2f);

        AudioListener.pause = true;      
        StartCoroutine(afterPain());
    }

    private IEnumerator afterPain()
    {
        yield return new WaitForSeconds(4f);
        
        player.GetComponent<FirstPersonController>().enabled = false;
        player.transform.Rotate(Vector3.back, 90f);
        StartCoroutine(death());

    }

    private IEnumerator death()
    {
        yield return new WaitForSeconds(2f);
        blackOut.PlayAnimOut(3);
        //blackOut.

    }
}
