using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuscript : MonoBehaviour
{
    public void PlayButton()

    // adds one onto the build index so it moves to the level under
    {
        SceneManager.LoadScene(1);
    }

    public void mainmenubutton()

    // takesaway one onto the build index so it moves to the level under
    {
        SceneManager.LoadScene(0);
    }


    public void QuitButton()
    {
        Debug.Log ("testpassed");

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
