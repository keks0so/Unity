using UnityEngine;
using System.Collections;
 
public class RayPannel : MonoBehaviour 
{

 
    public GameObject Panel;
 
     //Change me to change the touch phase used.
    void Start()
    {
        Panel.SetActive(false);
    }
 
    
    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Panel.SetActive(true);
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Panel.SetActive(false);
    }
        
    
}
