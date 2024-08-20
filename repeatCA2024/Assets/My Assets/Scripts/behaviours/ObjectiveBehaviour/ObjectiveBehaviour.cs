using AVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public abstract class ObjectiveBehaviour : MonoBehaviour, ICollidable
{

    [SerializeField]
    private SoundType soundType;

        public void OnCollision()
        {
 
            if (GameStateManager.Instance.UpdateGameState())
            {
                HandleObjective();
                GameStateManager.Instance.IncrementObjective();
                SoundManager.Instance.PlaySound(soundType);
           
            }

        }
        protected abstract void HandleObjective();


    }
