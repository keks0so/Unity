using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    public GameObject pannel1;
    public GameObject pannel2;
    public GameObject pannel3;
    public GameObject pannel4;
    public GameObject pannel5;
    public GameObject pannel6;
    public GameObject pannel7;
    public GameObject pannel8;
    public GameObject pannel9;
    public GameObject pannel10;
    public GameObject gem1;
    public GameObject gem2;
    public GameObject gem3;
    public GameObject gem4;
    public GameObject gem5;
    public GameObject gem6;
    public GameObject gem7;
    public GameObject gem8;
    public GameObject gem9;
    public GameObject gem10;
    void Start()
    {
        if(sc.Instance.ab1==true)
        {
            pannel1.SetActive(true);
            gem1.SetActive(true);
        }
        if(sc.Instance.ab2==true)
        {
            pannel2.SetActive(true);
            gem2.SetActive(true);
        }
        if(sc.Instance.ab3==true)
        {
            pannel3.SetActive(true);
            gem3.SetActive(true);
        }
        if(sc.Instance.ab4==true)
        {
            pannel4.SetActive(true);
            gem4.SetActive(true);
        }
        if(sc.Instance.ab5==true)
        {
            pannel5.SetActive(true);
            gem5.SetActive(true);
        }
        if(sc.Instance.ab6==true)
        {
            pannel6.SetActive(true);
            gem6.SetActive(true);
        }
        if(sc.Instance.ab7==true)
        {
            pannel7.SetActive(true);
            gem7.SetActive(true);
        }
        if(sc.Instance.ab8==true)
        {
            pannel8.SetActive(true);
            gem8.SetActive(true);
        }
        if(sc.Instance.ab9==true)
        {
            pannel9.SetActive(true);
            gem9.SetActive(true);
        }
        if(sc.Instance.ab10==true)
        {
            pannel10.SetActive(true);
            gem10.SetActive(true);
        }
    }

    
}
