﻿using Sirenix.OdinInspector;
using UnityEngine;

namespace AVR
{
    /// <see cref="https://www.youtube.com/watch?v=PVOVIxNxxeQ"/>
    public abstract class BaseObjectData : ScriptableGameObject
    {
        //[Tooltip("Specify the type of this object (e.g. equipment, food, weapon)")]
        // [DynamicTooltip()]
        [EnumPaging]
        public ItemType Type;
    }
}