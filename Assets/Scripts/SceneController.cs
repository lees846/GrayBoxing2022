using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string sceneToLoad;
    public Animator UIFade;

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeScene();
        }
    }
    void ChangeScene()
    {
        // Variable input scene name manually from Unity Editor
        SceneManager.LoadScene(sceneToLoad);
    }

    void TransitionScene()
    {
        StartCoroutine(PlayTransition());
    }
    // This is a coroutine - timeout within the function
    IEnumerator PlayTransition()
    {
        UIFade.SetTrigger("Start");
        // Yield allows code to wait for the duration of the animation
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneToLoad);
    }
}
