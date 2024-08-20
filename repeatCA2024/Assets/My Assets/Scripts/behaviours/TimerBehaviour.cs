using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

//timer code https://www.youtube.com/watch?v=POq1i8FyRyQ&list=LL&index=18 line 57 -73

public class TimerBehaviour : MonoBehaviour
{
    private TextMeshProUGUI timerUI;

    [SerializeField]
    private float timeleft;

    private bool isTimerFrozen = false;

    public TextMeshProUGUI TimerUI
    {
        get { return timerUI; }
    }

    public bool IsTimerFrozen 
    {  
        get { return isTimerFrozen; } 
        set { isTimerFrozen = value; }
    }
    private void Start()
    {
        timerUI = GetComponent<TextMeshProUGUI>();
    }

    public void SetEndTimer()
    {
        timerUI.color = Color.red;

        if (timeleft >= 45f)
        {
            timeleft = 45f;
        }
    }

    //Counts down
    void Update()
    {
        if (!isTimerFrozen)
        {
            UpdateTimer();
        }


    }

    private void UpdateTimer()
    {
        //if timer is higher then zero take away time
        if (timeleft >= 0)
        {
            timeleft -= Time.deltaTime;
        }
        else
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
