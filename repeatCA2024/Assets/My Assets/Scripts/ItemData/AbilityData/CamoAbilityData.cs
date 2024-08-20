using AVR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Burst.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "CamoAbilityData",
       menuName = "AVR/Scriptable Objects/Game/AbilityData/CamoAbilityData")]
public class CamoAbilityData : AbilityData
    {
        [SerializeField]
        private Material camouflageMaterial;

        private Material originalMaterial;

        private Renderer playerRenderer;  



        public override void ActivateAbility(GameObject player)
        {
            playerRenderer = player.transform.Find("Model").transform.Find("Body").GetComponent<Renderer>();

            if (playerRenderer != null && camouflageMaterial != null)
            {
                originalMaterial = playerRenderer.material;
                playerRenderer.material = camouflageMaterial;
               
            }

            player.GetComponent<PlayerController>().IsCamouflaged = true;
    }

        public override void DeactivateAbility(GameObject player)
        {
            if (playerRenderer != null && originalMaterial != null)
            {
                playerRenderer.material = originalMaterial;
            }

            player.GetComponent<PlayerController>().IsCamouflaged = false;
    }



    }

