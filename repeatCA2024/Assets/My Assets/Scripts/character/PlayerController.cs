using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// movement code https://www.youtube.com/watch?v=CIJtpkN_e8A&list=LL&index=11 line 14 -18 and line 39-72

namespace AVR
{

    public class PlayerController : MonoBehaviour
    {
        public Camera Camera;

        private RaycastHit hit;

        private NavMeshAgent agent;

        private bool isCamouflaged;

        [SerializeField]
        private TimerBehaviour timer;

        public bool IsCamouflaged
        {
            get { return isCamouflaged; }
            set { isCamouflaged = value;}
        }

        public TimerBehaviour Timer
        {
            get { return timer; }
        }

        private string floortag = "floor";

        // Start is called before the first frame update
        void Start()
        {

            agent = GetComponent<NavMeshAgent>();
           

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                    if (hit.collider.CompareTag(floortag))
                    {
                       
                        agent.SetDestination(hit.point);
                  




                    }
                   

                }
            }

        }


      

    }
}
