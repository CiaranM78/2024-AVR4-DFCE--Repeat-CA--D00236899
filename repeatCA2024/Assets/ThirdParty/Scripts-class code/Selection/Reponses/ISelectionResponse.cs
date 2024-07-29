using UnityEngine;

namespace AVR.Selection
{
    public interface ISelectionResponse
    {
        void OnSelect(Transform transform);
        void OnDeselect(Transform transform);
    }
}
