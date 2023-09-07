using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


[System.Serializable]
public class door : MonoBehaviour
{
    public GameObject dialoguePanelDoor;
    public Text dialogueTextDoor;
    public string[] DoorLines;
    public bool playerIsCloseDoor;
    public GameObject KeyEDoor;
    public GameObject AplayButtonDoor;
    public GameObject DisButtonDoor;
    public GameObject AgrButtonDoor;

    void Update()
    {

        if (playerIsCloseDoor)
        {
            KeyEDoor.SetActive(true);
        }
        else
        {
           KeyEDoor.SetActive(false); 
        }
        
        

        if (Input.GetKeyDown(KeyCode.E) && playerIsCloseDoor ) 
        
        {
            dialoguePanelDoor.SetActive(true);
            if (abcontroller.kol>6)  
            {
                AplayButtonDoor.SetActive(true);
                DisButtonDoor.SetActive(true);
                dialogueTextDoor.text = DoorLines[1];
            }
                
            if (abcontroller.kol<=6)
            {
                AgrButtonDoor.SetActive(true);
                dialogueTextDoor.text = DoorLines[0];
            }
                
        }

        
        
    }
   
    public void close()
    {
        dialoguePanelDoor.SetActive(false);
        AplayButtonDoor.SetActive(false);
        DisButtonDoor.SetActive(false);
        AgrButtonDoor.SetActive(false);
    }

    public void next()
    {
        SceneManager.LoadScene(3);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerIsCloseDoor = true;
        }
 

    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerIsCloseDoor = false;
        }
    }
}
