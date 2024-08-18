using AVR;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NoteController : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI bodyText;

    [SerializeField]
    private TextMeshProUGUI authorText;

    [SerializeField]
    private TextMeshProUGUI dateText;

    [SerializeField]
    private PlayerController playerController;

    public void SetNoteUI(NoteData noteData)
    {
    
            bodyText.text = "Dear Diary, \n" + noteData.Description;
            authorText.text = noteData.Author;
            dateText.text = noteData.Date;

    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            playerController.enabled = true;
            gameObject.SetActive(false);
        }
    }



}
