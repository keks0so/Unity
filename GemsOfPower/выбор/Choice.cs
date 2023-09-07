using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{

    public GameObject TextBox;
    public GameObject RGemAplay;
    public GameObject RGemDis;
    public int ChoiceMade;

    public void ChoiceOption1 ()
    {
        
        ChoiceMade = 1;
    }
    public void ChoiceOption2 ()
    {
        
        ChoiceMade = 2;
    }
 
}
