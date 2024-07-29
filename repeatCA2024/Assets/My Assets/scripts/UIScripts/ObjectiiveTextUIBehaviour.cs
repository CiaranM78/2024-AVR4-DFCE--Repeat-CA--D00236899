using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;



public class ObjectiiveTextUIBehaviour : MonoBehaviour
{
    
    private TextMeshProUGUI textMeshPro;

    [SerializeField]
    private ObjectivesData objectivesData;




    // Start is called before the first frame update
    void Start()
    {

        textMeshPro = GetComponent<TextMeshProUGUI>();



    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = objectivesData.GetObjectiveData().Description;

        
    }
}
