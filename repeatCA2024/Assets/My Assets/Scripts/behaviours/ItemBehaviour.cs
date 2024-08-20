using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AVR
{
    public class ItemBehaviour : MonoBehaviour, ICollidable
    {

        public ItemData ItemData;

        [SerializeField]
        private ObjectiveItemDataGameEvent addInventoryEvent;

        [SerializeField]
        private NoteDataGameEvent noteDataUIEvent;

        public void OnCollision()
        {
            if (ItemData is NoteData)
            {
                noteDataUIEvent.Raise(ItemData as NoteData);
                SoundManager.Instance.PlaySoundOneShot(SoundType.Note);

            }
 
            addInventoryEvent.Raise(ItemData);
            Destroy(gameObject);

           

        }


    }
}