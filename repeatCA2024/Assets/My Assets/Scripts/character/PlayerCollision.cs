using AVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


    public class PlayerCollision : MonoBehaviour
    {

    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<ICollidable>() != null)
        {
            other.GetComponent<ICollidable>().OnCollision();
        }


    }


        
    }


