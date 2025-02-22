﻿using UnityEngine;

namespace AVR
{
    [CreateAssetMenu(fileName = "StringVariable", menuName = "DkIT/Scriptable Objects/Types/Variables/String", order = 4)]
    public class StringVariable : ScriptableDataType<string>
    {
        public void Add(string a)
        {
            Value += a;
        }

        public void Add(StringVariable a)
        {
            Add(a.Value);
        }

        public bool IsNullOrEmpty()
        {
            return string.IsNullOrEmpty(Value);
        }
    }
}