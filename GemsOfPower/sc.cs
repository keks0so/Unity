using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sc : MonoBehaviour 
{
public static sc Instance;
public bool ab1;
public bool ab2;
public bool ab3;
public bool ab4;
public bool ab5;
public bool ab6;
public bool ab7;
public bool ab8;
public bool ab9;
public bool ab10;




void Start()
{
    
        
        ab1 = sc.Instance.ab1;
        ab2 = sc.Instance.ab2;
        ab3 = sc.Instance.ab3;
        ab4 = sc.Instance.ab4;
        ab5 = sc.Instance.ab5;
        ab6 = sc.Instance.ab6;
        ab7 = sc.Instance.ab7;
        ab8 = sc.Instance.ab8;
        ab9 = sc.Instance.ab9;
        ab10 = sc.Instance.ab10;

        
        
}

    void Awake ()   
       {
        
        
        
        if (Instance == null)
        {
            
            Instance = this;
            DontDestroyOnLoad(gameObject);
            
        }
        
        else if (Instance != this)
        {
            Destroy (gameObject);
            
            
        }



      }

    void Update()
    {
        ab1 = sc.Instance.ab1;
        ab2 = sc.Instance.ab2;
        ab3 = sc.Instance.ab3;
        ab4 = sc.Instance.ab4;
        ab5 = sc.Instance.ab5;
        ab6 = sc.Instance.ab6;
        ab7 = sc.Instance.ab7;
        ab8 = sc.Instance.ab8;
        ab9 = sc.Instance.ab9;
        ab10 = sc.Instance.ab10;

    }

}