using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeScript : MonoBehaviour
{
    public Animator anim;

    public void PlayAnimOut(int buildIndex)
    {
        anim.SetTrigger("FadeOut");
        StartCoroutine(sceneChange(buildIndex));
    }

    private void Awake()
    {
        AudioListener.pause = false;
        anim.SetTrigger("FadeIn");
    }

    private IEnumerator sceneChange(int buildIndex)
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(buildIndex);
    }

}