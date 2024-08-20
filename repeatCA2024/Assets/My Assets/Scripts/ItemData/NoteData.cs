using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace AVR
{
    [CreateAssetMenu(fileName = "ObjectiveItemData",
       menuName = "AVR/Scriptable Objects/Game/NoteData")]

    public class NoteData : ItemData
    {
        [SerializeField]
        private int day;

        [SerializeField]
        private int month;

        [SerializeField]
        private int year;

        [SerializeField]
        private string author;

        public string Date
        {
            get { DateTime date = new DateTime(year, month, day);
                return date.ToString("dd/MM/yyyy");
            }
        }

        public string Author
        {
            get { return author; }
        }
    }
}