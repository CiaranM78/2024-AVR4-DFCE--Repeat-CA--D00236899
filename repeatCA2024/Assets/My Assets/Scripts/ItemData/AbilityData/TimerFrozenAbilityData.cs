using AVR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "TimerFrozenAbilityData",
       menuName = "AVR/Scriptable Objects/Game/AbilityData/TimerFrozenAbilityData")]

public class TimerFrozenAbilityData : AbilityData
{
    private TimerBehaviour timerBehaviour;
    public override void ActivateAbility(GameObject player)
    {
        timerBehaviour = player.GetComponent<PlayerController>().Timer;

        timerBehaviour.IsTimerFrozen = true;
        timerBehaviour.TimerUI.color = Color.red;
    }

    public override void DeactivateAbility(GameObject player)
    {
        timerBehaviour.IsTimerFrozen = false;
        timerBehaviour.TimerUI.color = Color.white;
    }

}
