using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onpaused : MonoBehaviour
{


    [SerializeField]
    GameObject pausemenu;
    [SerializeField]
    GameObject inventoryUI;
    [SerializeField]
    public GameObject pausedgame;

    public bool paused;
 

    // Start is called before the first frame update
    void Start()
    {
        pausemenu.SetActive(false);
        inventoryUI.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                resumegame();
            }
            else
            {
                gamepaused();
            }
        }

    }

    public void gamepaused()
    {
        pausemenu.SetActive(true);
        inventoryUI.SetActive(false);
        Time.timeScale = 0f;
        paused = true;

    }

    public void resumegame()
    {

        pausemenu.SetActive(false);
        inventoryUI.SetActive(true);
        Time.timeScale = 1f;
        paused = false;
    }


}
