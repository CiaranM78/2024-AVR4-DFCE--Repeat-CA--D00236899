using AVR;
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
        Debug.Log("Set Sprite Method");
        Debug.Log(itemData.ItemName);
        Debug.Log(itemData.SpriteIcon);
     

        images[currentIndex].sprite = itemData.SpriteIcon;
        currentIndex++;
    }


public void RemoveSprite(ItemData itemData)
    {
        //images[currentIndex].sprite = null;

        //currentIndex--;





    }

    public void RemoveAtAndShift(int index)
    {
        if (index < 0 || index >= images.Length)
        {
            Debug.LogError("out of index");
            return;
        }

       
        images[index].sprite = null;

        
        for (int i = index; i < images.Length - 1; i++)
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

    public void PrintImagesArray()
    {
        for (int i = 0; i < images.Length; i++)
        {
            Debug.Log($"Image[{i}] sprite: {(images[i].sprite != null ? images[i].sprite.name : "null")}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(ObjectiveDatas.GetObjectiveData());
        //if (images == null)
        //{
        //    Debug.LogError("Images array is null!");
        //}


    }

}




