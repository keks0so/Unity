using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Diagnostics;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;


public class Eztext3 : MonoBehaviour
{
    
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

    
    public string someText = "";
    
    public Text textComponent;
    [TextArea(6, 10)]
    public string[] lines;

    private  List <string> num = new List <string>();
    private List <string> sex = new List <string>();
    
    private string a, b, c, d, nunu, res, final_res_str;
    private int n, m,g;

    
    // Start is called before the first frame update
    void Start()
    {
      
        g=0;
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
        if(ab1==true)
        {
        
          num.Add("0");
          g++;
          
        }  
          if(ab2==true)
        {
          num.Add("1");
           g++;
        }
        if(ab3==true)
        {
          num.Add("2");
           g++;
        }
        if(ab4==true)
        {
          num.Add("3");
           g++;
        }
        if(ab5==true)
        {
          num.Add("4");
           g++;
        }
        if(ab6==true)
        {
          num.Add("5");
           g++;
        }
        if(ab7==true)
        {
          num.Add("6");
           g++;
        }
        if(ab8==true)
        {
          num.Add("7");
           g++;
        }
        if(ab9==true)
        {
            num.Add("8");
            g++;
        }
        if(ab10==true)
        {
            num.Add("9");
            g++;
        }
        
        m = 0;
        for (int i = 0; i < g; i++)
        {
            a = num[i];
            
            for (int o = 1; o < g; o++)
            {
                
                b = num[o];
                for (int p = 2; p < g; p++)
                {
                    c = num[p];
                    if ((a == b) || (b == c) || (a == c))
                    {
                        break;
                    }
                    d = a + b + c;
                    m = m + 1;
                    sex.Add(d);
                }
            }
        }
        

        int j = 0;
        int arrLength = sex.Count;
        while (j < arrLength)
        {
            nunu = sex[j];
            
            solution();
            
            string pred = res;

            if (j == 0)
                final_res_str = final_res_str + pred;
            else
                final_res_str = final_res_str + " " + pred;
            
            j = j + 1;
        }

        someText = final_res_str;


        

        if (final_res_str.Contains("med"))
        {
            //textComponent.text = textComponent.text + lines[0] + System.Environment.NewLine;
            textComponent.text = textComponent.text + lines[0] + System.Environment.NewLine;; 
        }
        if (final_res_str.Contains("it"))
        {
            textComponent.text = textComponent.text + lines[1] + System.Environment.NewLine;;  
        }
        if (final_res_str.Contains("people"))
        {
            textComponent.text = textComponent.text + lines[2] + System.Environment.NewLine;;  
        }
        if (final_res_str.Contains("avia"))
        {
            textComponent.text = textComponent.text + lines[3] + System.Environment.NewLine;;  
        }
        if (final_res_str.Contains("science"))
        {
            textComponent.text = textComponent.text + lines[4] + System.Environment.NewLine;;  
        }
        

       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Konchalo()
    {
        
        SceneManager.LoadScene(1);


    }

    void solution()
    {
        string exam = nunu;
        int med = 0;
        int it = 0;
        int people = 0;
        int avia = 0;
        int science = 0;
        int i = 0;
        while (i < 3)
        {
            if ((exam[i] == '2') || (exam[i] == '3') || (exam[i] == '9'))
                med = med + 1;
            if ((exam[i] == '0') || (exam[i] == '5') || (exam[i] == '6'))
                it = it + 1;
            if ((exam[i] == '5') || (exam[i] == '8') || (exam[i] == '9'))
                people = people + 1;
            if ((exam[i] == '1') || (exam[i] == '7') || (exam[i] == '9'))
                avia = avia + 1;
            if ((exam[i] == '0') || (exam[i] == '3') || (exam[i] == '4'))
                science = science + 1;

            i = i+1;
        } 


        List <int> lst = new List <int>(){med, it, people, avia, science};
        List <string> lst1 = new List <string>(){"med", "it", "people", "avia", "science"};
        
        
        
        if (lst.Contains(3))
        {
            int ind = lst.IndexOf(3);
            
            string res = lst1[ind];
        }  
        if(lst.Contains(2))
        {
            
            int ind = lst.IndexOf(2);
            
            res = lst1[ind];
            
            lst[ind] = 0;
            if (lst.Contains(2))
            {
                ind = lst.IndexOf(2);
                res = res + " " + lst1[ind];
            }
                
        }
            
        
    }
}
