using UnityEngine;

namespace AVR.Selection
{
    public class SphereCastSelector : MonoBehaviour, ISelector
    {
        [SerializeField]
        private string selectableTag = "Selectable";

        [SerializeField]
        private LayerMask layerMask;

        [SerializeField]
        [Range(0.01f, 10)]
        private float radius = 1;

        [SerializeField]
        [Range(0, 1000)]
        private float maxDistance = 10;

        private Transform selection;
        private Ray currentRay;
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
            currentRay = ray;
            if (Physics.SphereCast(ray, radius, out hitInfo, maxDistance, layerMask.value))
            {
                var currentSelection = hitInfo.transform;
                if (currentSelection.CompareTag(selectableTag))
                    selection = currentSelection;
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            if (selection != null)
                Gizmos.DrawWireSphere(currentRay.origin, radius);
        }
    }
}