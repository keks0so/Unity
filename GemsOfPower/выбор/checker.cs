using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checker : MonoBehaviour
{
    public GameObject save;
    public GameObject screen;
    public GameObject canvas;
    public GameObject drop;
    public int s=0;
    
    public void sex()
    {
        var gems=new List<bool>() {CheckGrid.Gem1,CheckGrid.Gem2,CheckGrid.Gem3,CheckGrid.Gem4,CheckGrid.Gem5,CheckGrid.Gem6,CheckGrid.Gem7,CheckGrid.Gem8,CheckGrid.Gem9,CheckGrid.Gem10};
       for (int i=0; i<gems.Count;i++)
            {   
                if(gems[i]==true)
                {
                    s=s+1;
                }
                if(gems[i]==false)
                {
                  s=s-1;
                }
                sc.Instance.ab1 = CheckGrid.Gem1;
                sc.Instance.ab2 = CheckGrid.Gem2;
                sc.Instance.ab3 = CheckGrid.Gem3;
                sc.Instance.ab4 = CheckGrid.Gem4;
                sc.Instance.ab5 = CheckGrid.Gem5;
                sc.Instance.ab6 = CheckGrid.Gem6;
                sc.Instance.ab7 = CheckGrid.Gem7;
                sc.Instance.ab8 = CheckGrid.Gem8;
                sc.Instance.ab9 = CheckGrid.Gem9;
                sc.Instance.ab10 = CheckGrid.Gem10;
            }
           
            if(s==-2)
                    {
                      next();
                    }
            if(s<-2||s>-2)
            {
              s=0;//код пихать сюда
            }
    
    }
    public void next()
    {
        canvas.SetActive(false);
        drop.SetActive(false);
        screen.SetActive(true);
        SceneManager.LoadScene(4); 
    }
}
