using UnityEngine;
using UnityEngine.SceneManagement;

public class OnButtonClickScript : MonoBehaviour
{
    public void ChangeSceneButton(int scene)
    {
        Debug.Log("GameScene");
        //SceneManager.LoadScene(scene);
    }

    public void CreditsButton(GameObject credits)
    {
        transform.parent.parent.gameObject.SetActive(false);
        credits.SetActive(true);
    }

    public void ToMainMenu(GameObject menu)
    {
        transform.parent.gameObject.SetActive(false);
        menu.SetActive(true);
    }

    public void ExitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
         Application.Quit();
#endif
    }
}
