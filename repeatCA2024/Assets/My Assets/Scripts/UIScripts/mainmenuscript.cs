using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// exit code https://discussions.unity.com/t/trying-to-get-the-exit-game-to-work/183425/2 line 25 -34

public class mainmenuscript : MonoBehaviour
{
    public void PlayButton()

   //loads the second level in the scenemanager
    {
        SceneManager.LoadScene(1);
    }

    public void mainmenubutton()

    //loads the first level in the scenemanager
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
