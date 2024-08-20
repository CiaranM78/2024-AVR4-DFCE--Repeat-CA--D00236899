using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AI;


[Serializable]
public class BoostData
{
    [SerializeField]
    private float speed = 8;

    [SerializeField]
    private float acceleration = 8;

    public float Speed
    {
        get { return speed; }
    }

    public float Acceleration
    {
        get { return acceleration; }
    }

}

[CreateAssetMenu(fileName = "BoostData",
       menuName = "AVR/Scriptable Objects/Game/AbilityData/BoostData")]
public class BoostAbilityData : AbilityData
{
    [SerializeField]
    private BoostData normalBoostData;

    [SerializeField]
    private BoostData boostData;


    public override void ActivateAbility(GameObject player)
    {
        player.GetComponent<NavMeshAgent>().speed = boostData.Speed;
        player.GetComponent<NavMeshAgent>().acceleration = boostData.Acceleration;
    }

    public override void DeactivateAbility(GameObject player)
    {
        player.GetComponent<NavMeshAgent>().speed = normalBoostData.Speed;
        player.GetComponent<NavMeshAgent>().acceleration = normalBoostData.Acceleration;
    }
}

