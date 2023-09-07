using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGrid2 : MonoBehaviour
{
   
    public void Update()
    {
        
        if(transform.childCount > 0)
        {
            foreach (Transform eachChild in transform) 
            {
                if (eachChild.name == "Item1") 
                {
                    CheckGrid.Gem1 = false;
                }
                if (eachChild.name == "Item2") 
                {
                    CheckGrid.Gem2 = false;
                }
                if (eachChild.name == "Item3") 
                {
                    CheckGrid.Gem3 = false;
                }
                if (eachChild.name == "Item4") 
                {
                    CheckGrid.Gem4 = false;
                }
                if (eachChild.name == "Item5") 
                {
                    CheckGrid.Gem5 = false;
                }
                if (eachChild.name == "Item6") 
                {
                    CheckGrid.Gem6 = false;
                }
                if (eachChild.name == "Item7") 
                {
                    CheckGrid.Gem7 = false;
                }
                if (eachChild.name == "Item8") 
                {
                    CheckGrid.Gem8 = false;
                }
                if (eachChild.name == "Item9") 
                {
                    CheckGrid.Gem9 = false;
                }
                if (eachChild.name == "Item10") 
                {
                    CheckGrid.Gem10 = false;
                }
            }
        }
        
    
    }
}
