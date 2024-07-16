using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daughtersickanim : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("sick", true);
    }

    // Update is called once per frame
    void Update()
    {


    }
}
