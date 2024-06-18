using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace repeatcacodelibrary  
{
    public class playercharacter : MonoBehaviour
    {
        public GameObject target;
        public GameObject mainCamera;

        private CharacterController controller;

        [SerializeField]
        private float minangle = -30;
        [SerializeField]
        private float maxangle = 70;
        [SerializeField]
        private float angleoveride;
        [SerializeField]
        private float mousesesitivity = 1;



        public float walkspeed = 1.5f;
        public float RotationSmoothTime = 0.12f;
        public float speedchange = 10.0f;
        public float rotation = 0.1f;
        private float cameratargetpitch;
        private float cameratargetyaw;
        private float targetspeed;
        private float targetrotation;
        private float rotationvelocity;
        private float speed;
        private float verticalvelocity = 0;

        private const float threshold = 0.01f;

        private Vector2 gaze;
        private Vector3 direction;


        private void Awake()
        {
            if (mainCamera == null)
            {
                mainCamera = GameObject.FindGameObjectWithTag("Maincamera");
                if (mainCamera == null)
                    throw new ArgumentNullException("cinemachine needs camera tag");
            }
        }

        private void Start()
        {
            cameratargetyaw = target.transform.rotation.eulerAngles.y;
            controller = GetComponent<CharacterController>();

        }

        private void Update()
        {
            imputmanager();
            Movement();

        }

        private void imputmanager()
        {
            direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

            gaze.x = Input.GetAxis("Mouse X") * mousesesitivity;
            gaze.y = Input.GetAxis("Mouse Y") * mousesesitivity;

            gaze.x = Input.GetAxis("Mouse X") * mousesesitivity;
            gaze.y = Input.GetAxis("Mouse Y") * mousesesitivity;
        }



        private void Movement()
        {
            targetspeed = walkspeed;

            if (direction.magnitude == 0) targetspeed = 0.0f;

            float currentHorizontalSpeed = new Vector3
                (controller.velocity.x, 0.0f, controller.velocity.z).magnitude;

            float speedOffset = 0.1f;
            float inputMagnitude = 1;


            if (currentHorizontalSpeed < targetspeed - speedOffset ||
                currentHorizontalSpeed > targetspeed + speedOffset)
            {

                speed = Mathf.Lerp(currentHorizontalSpeed, targetspeed * inputMagnitude, Time.deltaTime * speedchange);


                speed = Mathf.Round(speed * 1000f) / 1000f;
            }
            else
                speed = targetspeed;


            Vector3 inputDirection = new Vector3(direction.x, 0.0f, direction.y).normalized;


            if (direction.magnitude != 0)
            {
                targetrotation = Mathf.Atan2(inputDirection.x, inputDirection.z) * Mathf.Rad2Deg + mainCamera.transform.eulerAngles.y;
                float rotation = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetrotation, ref rotationvelocity, RotationSmoothTime);


                transform.rotation = Quaternion.Euler(0.0f, rotation, 0.0f);
            }

            Vector3 targetDirection = Quaternion.Euler(0.0f, targetrotation, 0.0f) * Vector3.forward;

            controller.Move(targetDirection.normalized * (speed * Time.deltaTime) + new Vector3(0.0f, verticalvelocity, 0.0f) * Time.deltaTime);
        }
    }
}