using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hint : MonoBehaviour
{
    public GameObject HintPanel;
    public int HintShit = 1;
    // Start is called before the first frame update
    void Start()
    {
        HintPanel.SetActive(true);
        HintShit = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Hide()
    {
        if(HintShit == 1)
        {
            HintPanel.SetActive(false);
            HintShit = 0;
        }
        else
        {
            HintPanel.SetActive(true);
            HintShit = 1;
        }
        
    }
}
