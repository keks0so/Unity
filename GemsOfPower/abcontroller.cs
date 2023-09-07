using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abcontroller : MonoBehaviour
{
    public GameObject ab1;
    public GameObject ab2;
    public GameObject ab3;
    public GameObject ab4;
    public GameObject ab5;
    public GameObject ab6;
    public GameObject ab7;
    public GameObject ab8;
    public GameObject ab9;
    public GameObject ab10;

    public static int kol;
   
    
    public static bool flagok;
    void Start()
    {
        flagok = false;
        kol = 0;
    }
    void Update()
    {
        if(flagok==true)
        {
            flag();
        }
        
    }
    void flag()
    {
        if(ab1.activeSelf)
        {
            sc.Instance.ab1 = ab1;
            kol++;
        }
        if (ab2.activeSelf)
        {
            sc.Instance.ab2 = ab2;
            kol++;
        }
        if (ab3.activeSelf)
        {
            sc.Instance.ab3 = ab3;
            kol++;
        }
        if (ab4.activeSelf)
        {
            sc.Instance.ab4 = ab4;
            kol++;
        }
        if (ab5.activeSelf)
        {
            sc.Instance.ab5 = ab5;
            kol++;
        }
        if (ab6.activeSelf)
        {
            sc.Instance.ab6 = ab6;
            kol++;
        }
        if (ab7.activeSelf)
        {
            sc.Instance.ab7 = ab7;
            kol++;
        }
        if (ab8.activeSelf)
        {
            sc.Instance.ab8 = ab8;
            kol++;
        }
        if (ab9.activeSelf)
        {
            sc.Instance.ab9 = ab9;
            kol++;
        }
        if (ab10.activeSelf)
        {
            sc.Instance.ab10 = ab10;
            kol++;
        }
        flagok = false;
    }
}
