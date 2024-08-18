using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class AbilityData : ItemData
{
    [SerializeField]
    private float duration = 10f;

    public float Duration
    {
        get { return duration; }
    }

    public abstract void ActivateAbility(GameObject player);


    public abstract void DeactivateAbility(GameObject player);





}
