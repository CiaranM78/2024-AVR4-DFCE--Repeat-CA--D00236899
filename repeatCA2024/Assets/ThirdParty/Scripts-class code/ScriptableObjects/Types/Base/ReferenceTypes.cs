﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Contains a set of ScriptableObject(SO) data types (float, int, bool) and reference types that can switch between a local variable (e.g float) or reference to a shared variable (e.g. FloatVariable)
/// </summary>
namespace AVR
{
    #region Generic Type

    [System.Serializable]
    public abstract class ScriptableDataType<T> : ScriptableGameObject, IComparer<ScriptableDataType<T>>, IComparable<ScriptableDataType<T>>
    {
        [SerializeField]
        [ContextMenuItem("Reset Value", "ResetValue")]
        private T value;

        public UnityEvent<T> OnSet;

        public T Value { get => value; set => this.value = value; }

        public virtual void Set(T value)
        {
            this.value = value;
            OnSet?.Invoke(this.value);
        }

        public virtual void ResetValue()
        {
            Set(default(T));
        }

        public override bool Equals(object obj)
        {
            return obj is ScriptableDataType<T> type &&
                   base.Equals(obj) &&
                   name == type.name &&
                   EqualityComparer<T>.Default.Equals(value, type.value) &&
                   EqualityComparer<T>.Default.Equals(Value, type.Value);
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(base.GetHashCode());
            hash.Add(value);
            return hash.ToHashCode();
        }

        public int CompareTo(ScriptableDataType<T> other)
        {
            return Compare(this, other);
        }

        public int Compare(ScriptableDataType<T> x, ScriptableDataType<T> y)
        {
            return Comparer<T>.Default.Compare(x.value, y.value);
        }
    }

    #endregion Generic Type

    #region Reference Types

    //Generic type to replace BoolReference, IntReference etc

    [System.Serializable]
    public class BaseReference<T>
    {
        public bool UseConstant = true;
        public T ConstantValue;
    }

    [System.Serializable]
    public class BoolReference : BaseReference<bool>
    {
        public BoolVariable Variable;
        public bool Value => UseConstant ? ConstantValue : Variable.Value;
    }

    [System.Serializable]
    public class IntReference : BaseReference<int>
    {
        public IntVariable Variable;
        public int Value => UseConstant ? ConstantValue : Variable.Value;
    }

    [System.Serializable]
    public class FloatReference : BaseReference<float>
    {
        public FloatVariable Variable;

        public float Value => UseConstant ? ConstantValue : Variable.Value;
    }

    [System.Serializable]
    public class StringReference : BaseReference<string>
    {
        public StringVariable Variable;
        public string Value => UseConstant ? ConstantValue : Variable.Value;
    }

    [System.Serializable]
    public class Vector3Reference : BaseReference<Vector3>
    {
        public Vector3Variable Variable;
        public Vector3 Value => UseConstant ? ConstantValue : Variable.Value;
    }

    #endregion Reference Types
}