using UnityEngine;

namespace AVR.Selection
{
    public interface ISelector
    {
        void Check(Ray ray);

        Transform GetSelection();

        RaycastHit GetHitInfo();
    }
}