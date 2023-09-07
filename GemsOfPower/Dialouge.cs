using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class Dialouge : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    [TextArea(5, 10)]

    public GameObject dialoguePanel;
    public string[] lines ;
    public float textSpeed;
    private int index;
    public bool playerIsClose;

    
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (playerIsClose)
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
                dialoguePanel.SetActive(false);
            }
            else
            {
                dialoguePanel.SetActive(true);
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine (TypeLine());

    }

    IEnumerator TypeLine()
    {
        foreach (var c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }

    }

    void NextLine()
    {
        if (index < lines.Length-1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine (TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
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
            index = 0;
            StartCoroutine (TypeLine());
            dialoguePanel.SetActive(false);
        }
    }

}
