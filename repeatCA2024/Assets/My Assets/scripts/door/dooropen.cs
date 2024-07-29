using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dooropen : MonoBehaviour
{

    [SerializeField]
    private Animator mydoor = null;

    [SerializeField]
    private bool mydoorEnabled = false;
    [SerializeField]
    private bool mydoorDisabled = false;

    private void OnTriggerEnter(Collider other)
    {
     if (other.CompareTag("Player"))
     {

            if (mydoorEnabled) 
            {

                mydoor.Play("open", 0, 0.0f);
                gameObject.SetActive(false);

                    }
        } 
     else if (mydoorDisabled)
        {
            mydoor.Play("close", 0, 0.0f);
            gameObject.SetActive(false);


        }
    }
    

    // Update is called once per frame
   
}
