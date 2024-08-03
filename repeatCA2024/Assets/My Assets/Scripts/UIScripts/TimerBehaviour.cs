using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public TextMeshProUGUI timerUI;
    public float timeleft;
    

    //Counts down
    void Update()
    {

        //if timer is higher then zero take away time
        if (timeleft > 0)
        {
            timeleft -= Time.deltaTime;
        }
        else if (timeleft < 0)
        {
            timeleft = 0;

            SceneManager.LoadScene(2);
        }

        //Seperates the number into minutes and seconds
        int minutes = Mathf.FloorToInt(timeleft / 60);
        int seconds = Mathf.FloorToInt(timeleft % 60);


        timerUI.text = string.Format("{0:00}:{1:00}", minutes, seconds);



    }
}
