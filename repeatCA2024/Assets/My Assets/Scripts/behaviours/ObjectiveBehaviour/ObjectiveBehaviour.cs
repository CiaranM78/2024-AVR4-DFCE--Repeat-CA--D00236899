using System.Collections;
using System.Collections.Generic;
using UnityEngine;




    public abstract class ObjectiveBehaviour : MonoBehaviour, ICollidable
    {
       


        public void OnCollision()
        {

        
            if (GameStateManager.Instance.UpdateGameState())
            {
                HandleObjective();
            }

        }
        protected abstract void HandleObjective();


    }
