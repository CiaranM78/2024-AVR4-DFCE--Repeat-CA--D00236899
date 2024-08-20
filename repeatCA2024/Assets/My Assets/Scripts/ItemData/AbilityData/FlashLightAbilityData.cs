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
        
        private Light playerLight;

        public override void ActivateAbility(GameObject player)
        {
            if (playerLight == null)
            {
                playerLight = player.GetComponent<Light>();
            }

            if (playerLight != null)
            {
                 playerLight.enabled = true;
            }
        }

        public override void DeactivateAbility(GameObject player)
        {
            if (playerLight != null)
            {
                playerLight.enabled = false;
            }
        }
    }

