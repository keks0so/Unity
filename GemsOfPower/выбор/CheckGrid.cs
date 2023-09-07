using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGrid : MonoBehaviour
{
    static public bool Gem1 = false;
    static public bool Gem2 = false;
    static public bool Gem3 = false;
    static public bool Gem4 = false;
    static public bool Gem5 = false;
    static public bool Gem6 = false;
    static public bool Gem7 = false;
    static public bool Gem8 = false;
    static public bool Gem9 = false;
    static public bool Gem10 = false;
    static public bool flag = false;
    

    //public CountSlot Gem1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {

        if (transform.childCount > 0)
        {
            foreach (Transform eachChild in transform) 
            {
                if (eachChild.name == "Item1") 
                {
                    Gem1 = true;
                    flag = true;
                }
                if (eachChild.name == "Item2") 
                {
                    Gem2 = true;
                    flag = true;
                }
                if (eachChild.name == "Item3") 
                {
                    Gem3 = true;
                    flag = true;
                }
                if (eachChild.name == "Item4") 
                {
                    Gem4 = true;
                    flag = true;
                }
                if (eachChild.name == "Item5") 
                {
                    Gem5 = true;
                    flag = true;
                }
                if (eachChild.name == "Item6") 
                {
                    Gem6 = true;
                    flag = true;
                }
                if (eachChild.name == "Item7") 
                {
                    Gem7 = true;
                    flag = true;
                }
                if (eachChild.name == "Item8") 
                {
                    Gem8 = true;
                    flag = true;
                }
                if (eachChild.name == "Item9") 
                {
                    Gem9 = true;
                    flag = true;
                }
                if (eachChild.name == "Item10") 
                {
                    Gem10 = true;
                    flag = true;
                }
            }
        }
    }
}
