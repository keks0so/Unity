using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]

public class GemR : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text dialogueText;
    public Text textComponent;
    [TextArea(5, 10)]
    public string[] lines;
    public string[] endoverlines;
    public string[] dialogue;
    private int index;
    private int endialog2;
    public GameObject KeyE;
    public GameObject AplayButton;
    public GameObject DisButton;
    public GameObject AgrButton;
    public GameObject QuestionBox;
    public GameObject Gem;
    public GameObject CollectedGem;
    public float wordSpeed;
    public bool playerIsClose;
    public bool dialogueIsOver;
    private bool Positive = false;
    

    
    public int amount = 1;
    
    public AudioSource audioData;


    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsClose)
        {
            KeyE.SetActive(true);
        }
        else
        {
           KeyE.SetActive(false); 
        }
        
        

        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        
        
        {
            
            
            if (dialogueIsOver)
            {
                dialoguePanel.SetActive(true);
                
                dialogueText.text = "";  
                endialog2 = 0;
                dialogueText.text = endoverlines[endialog2];
                
                
               
            }
            else
            {
                if (dialoguePanel.activeInHierarchy && dialogueIsOver != true)
                {
                    zeroText();
                }
                else
                {
                    dialoguePanel.SetActive(true);
                    StopAllCoroutines();
                    dialogueText.text = dialogue[index];
                    amount = 1;
                }  
            }
            

            
        }

        if (dialogueText.text == dialogue[index])
        {
            AplayButton.SetActive(true);
            DisButton.SetActive(true);
            
        }
        if (index>4)
        {
            AplayButton.SetActive(false);
            DisButton.SetActive(false);
        }
        
        

        
    }

    

    public void zeroText()
    {
        
        dialogueText.text = "";
        index=0;
        dialoguePanel.SetActive(false);

    }


    IEnumerator Typing()
    {
        
        
        if (index>4)
        {
            AgrButton.SetActive(true);
        }
        
        
            foreach(char letter in dialogue[index].ToCharArray())
            {
                dialogueText.text += letter;
                yield return new WaitForSeconds(wordSpeed);
            }
        
        
    }
    IEnumerator Writing()
    {
        foreach(char letter in endoverlines[endialog2].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void Nextline()
    {
        AplayButton.SetActive(false);
        DisButton.SetActive(false);

        if (index < dialogue.Length - 1)
        {
            
            index++;
            if (index > 4 && amount < 3)
            {

                endialog2 = 0;
                dialogueText.text = "";
                StartCoroutine(Writing());
                AgrButton.SetActive(true);
                dialogueIsOver = true;


            }
            if (index > 4 && amount >= 3)
            {
                index = 5;
                dialogueText.text = "";
                StartCoroutine(Typing());
            }
            if (index <= 4)
            {
                dialogueText.text = "";
                StartCoroutine(Typing());
            }


        }
        else
        {

            zeroText();
        }
    }


    public void QuestBox()
    {
        
        
        if (dialogueIsOver == true)
        {
            if(Positive == true)
            {
                
                //audioData.Play();
                Gem.SetActive(false);
                CollectedGem.SetActive(true);

                abcontroller.flagok = true;
            }
            if(Positive == false)
            {
                dialoguePanel.SetActive(false);
        
                dialogueIsOver = true;
                endialog2 = 0;
                dialogueText.text = "";
                dialogueText.text = endoverlines[endialog2];
                
            }
            
            
        }
        if (amount > 1 && dialogueIsOver != true)
        {
            dialoguePanel.SetActive(false);
            textComponent.text = "";
            textComponent.text = lines[0];
            QuestionBox.SetActive(true); 
             
        }
        
    }
    

    public void Endialog()
    {
        QuestionBox.SetActive(false);
        dialoguePanel.SetActive(true);
        dialogueText.text = "";  
        endialog2 = 0;
        dialogueText.text = endoverlines[endialog2];

        dialogueIsOver = true;
        
        
            
         
    }

    public void Counting()
    {
        amount = amount + 1;
    }

    public void distruction()
    {
        dialoguePanel.SetActive(true);
        
        dialogueText.text = "";
        endialog2 = 1;
        StartCoroutine(Writing());
        dialogueIsOver = true;
        
        QuestionBox.SetActive(false);
        Positive = true;
        
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
 

    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerIsClose = false;
            zeroText();
        }
    }


}
