using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "FlashLightAbilityData",
       menuName = "AVR/Scriptable Objects/Game/AbilityData/FlashLightAbilityData")]
public class FlashLightAbilityData : AbilityData
{
        [SerializeField]
        private Light playerLight;

        [SerializeField]
        private bool isLightOn = false;


        public override void ActivateAbility(GameObject player)
        {
            if (playerLight == null)
            {
                
                playerLight = player.GetComponentInChildren<Light>();
            }

            if (playerLight != null)
            {
                 playerLight.enabled = true;
                 isLightOn = true;
            }
        }

        public override void DeactivateAbility(GameObject player)
        {
            if (playerLight != null)
            {
                playerLight.enabled = false;
                isLightOn = false;
            }
        }
    }

