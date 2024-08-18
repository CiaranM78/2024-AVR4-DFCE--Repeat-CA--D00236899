using Assets.My_Assets.Scripts.Controllers;
using AVR;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace AVR
{

    public class UIManager : Singleton<UIManager>
    {


        [SerializeField]
        public GameObject pauseUIObject;

        [SerializeField]
        private ObjectivesData objectivesData;

        [SerializeField]
        public Image[] images;
        private int currentIndex = 0;

        [SerializeField]
        private TextMeshProUGUI currentObjectiveText;

        [SerializeField]
        private Transform objectivePanel;

        [SerializeField]
        private GameObject itemUIPrefab;



        public void SetSprite(ItemData itemData)
        {
            images[currentIndex].gameObject.GetComponent<RemoveItemController>().ItemData = itemData;
            images[currentIndex].sprite = itemData.SpriteIcon;
            currentIndex++;
        }

        private void Start()
        {
           SetObjectiveText();
        }

        public void SetObjectiveText()
        {
            currentObjectiveText.text = objectivesData.GetCurrentObjectiveData().Description;

            foreach (ItemData item in objectivesData.GetCurrentObjectiveData().ItemDatas)
            {
                var newItem = Instantiate(itemUIPrefab, objectivePanel);
                newItem.transform.Find("Label").GetComponent<Text>().text = item.ItemName;
                newItem.transform.Find("Sprite").GetComponent<Image>().sprite = item.SpriteIcon;
                newItem.GetComponent<ObjectiveLabel>().ItemData = item;
            }
        }

        public void UpdateObjectives(ItemData itemData)
        {
            foreach (Transform gameObject in objectivePanel)
            {
                if (gameObject.GetComponent<ObjectiveLabel>().ItemData == itemData)
                {
                    gameObject.transform.Find("Line").gameObject.SetActive(true);
                }
            }
        }

        public void RemoveSprite(ItemData itemData)
        {
            int index = 0;

            //images[currentIndex].sprite = null;
            currentIndex--;
            for (int i = 0; i <= currentIndex; i++)
            {
                if (images[i].gameObject.GetComponent<RemoveItemController>().ItemData.ItemName == itemData.ItemName)
                {
                    index = i; break;
                }
            }
            RemoveAtAndShift(index);
        }

        public void RemoveAtAndShift(int index)
        {

            if (index < 0 || index >= images.Length)
            {
                Debug.LogError("out of index");
                return;
            }


            images[index].sprite = null;


            for (int i = index; i <= currentIndex; i++)
            {
                if (images[i + 1] != null && images[i + 1].sprite != null)
                {
                    images[i].sprite = images[i + 1].sprite;
                    images[i + 1].sprite = null;
                }
                else
                {
                    images[i].sprite = null;
                    break;
                }
            }
        }

        public void SetEndObjectiveText()
        {
            currentObjectiveText.text = objectivesData.GetCurrentObjectiveData().EndDescription;
        }
    }


}

