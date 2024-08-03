using Assets.My_Assets.Scripts.Controllers;
using AVR;
using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager> 
{ 
    

    public GameObject pauseUIobject;

    [SerializeField]
    private ObjectivesData objective;

    [SerializeField]
    public Image[] images;
    private int currentIndex = 0;


    public void SetSprite(ItemData itemData)
    {
        images[currentIndex].gameObject.GetComponent<RemoveItemController>().ItemData = itemData;
        images[currentIndex].sprite = itemData.SpriteIcon;
        currentIndex++;
    }


public void RemoveSprite(ItemData itemData)
    {
        int index = 0;

        //images[currentIndex].sprite = null;
        currentIndex--;
        for (int i = 0; i <= currentIndex ; i++)
        {
            if (images[i].gameObject.GetComponent<RemoveItemController>().ItemData.ItemName == itemData.ItemName)
            {
                Debug.Log("Boom "+ i);
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

}




