 using UnityEngine;
 using System.Collections;
 
 public class MousePointer : MonoBehaviour
 {
    public GameObject panel;

    public void Start()
    {
        panel.SetActive(false);
    }

    public void OnMouseOver()
    {
        panel.SetActive(true);
    }

    public void OnMouseExit()
    {
        panel.SetActive(false);
    }
}