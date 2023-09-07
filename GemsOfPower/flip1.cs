using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip1 : MonoBehaviour
{
    public bool a;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
     a=true;
     anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw ("Horizontal"); //the value will be -1 0 or 1 (for left no input, and right)
        float y = Input.GetAxisRaw ("Vertical");
        if(x>0&&a==true)
        {
           transform.localScale*=new Vector2(-1,1);
           a=false;  
        }
        else
        if(x<0&&a==false)
        {
          transform.localScale*=new Vector2(-1,1);
          a=true;
        }
        anima();
    }
    void anima()
    {
      float x = Input.GetAxisRaw ("Horizontal"); //the value will be -1 0 or 1 (for left no input, and right)
      float y = Input.GetAxisRaw ("Vertical");
      if(x!=0||y!=0){
      anim.SetBool("move",(true));
      }
      else{anim.SetBool("move",(false));}
    }
}
