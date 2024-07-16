using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AVR
{

    public class walkinganim : MonoBehaviour
    {
        Animator animator;

        // Start is called before the first frame update
        void Start()
        {
            animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                animator.SetBool("iswalking", true);

                if (Input.GetMouseButton(1))
                {
                    animator.SetBool("iswalking", false);
                }
            }
          

        }
    }

}
