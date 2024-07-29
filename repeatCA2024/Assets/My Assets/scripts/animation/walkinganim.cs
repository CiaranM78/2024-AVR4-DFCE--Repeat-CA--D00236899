using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace AVR
{

    public class walkinganim : MonoBehaviour
    {
        Animator animator;

        [SerializeField]
        private NavMeshAgent agent;

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

            }


            if (Vector3.Distance(agent.destination, transform.position)
               <= agent.stoppingDistance)
            {
                StartCoroutine(Wait());
                animator.SetBool("iswalking", false);

            }

        }

        private IEnumerator Wait()
        {
            yield return new WaitForSeconds(0.5f);

        }


    }

}
