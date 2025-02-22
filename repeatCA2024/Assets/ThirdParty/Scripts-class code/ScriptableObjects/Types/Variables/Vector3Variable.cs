﻿using UnityEngine;

namespace AVR
{
    [CreateAssetMenu(fileName = "Vector3Variable", menuName = "DkIT/Scriptable Objects/Types/Variables/Vector3", order = 5)]
    public class Vector3Variable : ScriptableDataType<Vector3>
    {
        public void Add(Vector3 a)
        {
            Value += a;
        }

        public void Add(Vector3Variable a)
        {
            Add(a.Value);
        }
    }
}