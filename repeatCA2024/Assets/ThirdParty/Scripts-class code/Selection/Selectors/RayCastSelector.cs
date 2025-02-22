﻿using UnityEngine;

namespace AVR.Selection
{
    public class RayCastSelector : MonoBehaviour, ISelector
    {
        [SerializeField]
        [Tooltip("Define the tag used by selectable objects")]
        private string selectableTag = "Selectable";

        [SerializeField]
        [Tooltip("Define the layer to which selectable objects belong")]
        private LayerMask layerMask;

        [SerializeField]
        [Range(0.01f, 500)]
        [Tooltip("Define the max distance(metres) over which to allow selection")]
        private float maxDistance = 50;

        private Transform selection;
        private RaycastHit hitInfo;

        public Transform GetSelection()
        {
            return selection;
        }

        public RaycastHit GetHitInfo()
        {
            return hitInfo;
        }

        public void Check(Ray ray)
        {
            selection = null;
            if (Physics.Raycast(ray, out hitInfo, maxDistance, layerMask.value))
            {
                var currentSelection = hitInfo.transform;
                if (currentSelection.CompareTag(selectableTag))
                    selection = currentSelection;
            }
        }
    }
}