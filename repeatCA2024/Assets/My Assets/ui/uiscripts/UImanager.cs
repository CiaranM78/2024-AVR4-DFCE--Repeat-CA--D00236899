using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    

    GameObject pauseUIobject;

    [SerializeField]
    private ObjectiveDatas objective;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(ObjectiveDatas.GetObjectiveData());


    }










    void gamepaused()
    {


    }
}
