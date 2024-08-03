using AVR.Selection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelectionResponce : MonoBehaviour, ISelectionResponse
{
    public void OnDeselect(Transform transform)
    {
       // Debug.Log("deselected"); 
    }

    public void OnSelect(Transform transform)
    {
      //  Debug.Log("tessst");
       
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
