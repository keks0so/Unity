 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Random = System.Random;
using System;
using UnityEngine.SceneManagement;
[System.Serializable]

public class Battle1 : MonoBehaviour
{
  public Text ManaText;
  public int maxHealth = 100;
  static public int currentHealth;
  public HealthBar healthBar;
  
  public int maxHealthPlayer = 150;
  public int currentHealthPlayer;
  public HealthBar healthBarPl;
  public GameObject Player;
  public GameObject Enemy;
  Animator animator;
  public int hp;
  public int Eh;
   
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
   

    private bool Plf = true;
    private bool Enf = false;
    private bool Fight = true;
    
    public int mana = 20;
    public int pldmg;
    public int endmg;
    public int hl;

    public float StartTimeBtwFight;
    private float TimeBtwFight;

    public int silens;
    private int boost;
    private int Bedmg;
    private int ssh;
    private int kislotadmg;
    private int kislota;

    public float TimeBtw;
    public float TimeBt;

    public GameObject whit;
    public GameObject fm;
    public GameObject dk;
    public GameObject hm;
    public GameObject tm;
    public GameObject Gem1;
    public GameObject GemPanel1;
    public GameObject Gem2;
    public GameObject GemPanel2;
    public GameObject Gem3;
    public GameObject GemPanel3;
    public GameObject Gem4;
    public GameObject GemPanel4;
    public GameObject Gem5;
    public GameObject GemPanel5;
    public GameObject Gem6;
    public GameObject GemPanel6;
    public GameObject Gem7;
    public GameObject GemPanel7;
    public GameObject Gem8;
    public GameObject GemPanel8;
    public GameObject Gem9;
    public GameObject GemPanel9;
    public GameObject Gem10;
    public GameObject GemPanel10;

    public GameObject LoadScreen;
    public GameObject Canvas;
    public GameObject kristal;

    private int x_p = 275;
    private int y_p = 860;
    private int x_g = -10;
    private int y_g = 6;

    private int step_p = 137;
    private int step_g = 2;

    private bool sox=true;
    private int value;

    private bool lapka = true;
    
    void Start()
    {
        TimeBtw=400f;
        kislota=1;
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        currentHealthPlayer = maxHealthPlayer;
        healthBarPl.SetMaxHealth(maxHealthPlayer);

        Bedmg=0;
        TimeBtwFight = StartTimeBtwFight; 
        animator = GetComponent<Animator>();
        StartTimeBtwFight = 3;
        ab1 =sc.Instance.ab1;
        ab2 =sc.Instance.ab2;
        ab3 =sc.Instance.ab3;
        ab4 = sc.Instance.ab4;
        ab5 = sc.Instance.ab5;
        ab6 = sc.Instance.ab6;
        ab7 = sc.Instance.ab7;
        ab8 = sc.Instance.ab8;
        ab9 = sc.Instance.ab9;
        ab10 = sc.Instance.ab10;
        silens=0;
        boost=1;

        TimeBtw = 1300;
        if(ab1==true)
        {
          Gem1.transform.position= new Vector2 (x_g,y_g);
          Gem1.SetActive(true);
          GemPanel1.transform.position= new Vector2 (x_p,y_p);
          
          x_g=x_g+step_g;
          x_p=x_p+step_p;
        }
        if(ab2==true)
        {
          Gem2.transform.position= new Vector2 (x_g,y_g);
          Gem2.SetActive(true);
          GemPanel2.transform.position= new Vector2 (x_p,y_p);
          x_g=x_g+step_g;
          x_p=x_p+step_p;
        }
        if(ab3==true)
        {
          Gem3.transform.position= new Vector2 (x_g,y_g);
          Gem3.SetActive(true);
          GemPanel3.transform.position= new Vector2 (x_p,y_p);
          x_g=x_g+step_g;
          x_p=x_p+step_p;
        }
        if(ab4==true)
        {
          Gem4.transform.position= new Vector2 (x_g,y_g);
          Gem4.SetActive(true);
          GemPanel4.transform.position= new Vector2 (x_p,y_p);
          x_g=x_g+step_g;
          x_p=x_p+step_p;
        }
        if(ab5==true)
        {
          Gem5.transform.position= new Vector2 (x_g,y_g);
          Gem5.SetActive(true);
          GemPanel5.transform.position= new Vector2 (x_p,y_p);
          x_g=x_g+step_g;
          x_p=x_p+step_p;
        }
        if(ab6==true)
        {
          Gem6.transform.position= new Vector2 (x_g,y_g);
          Gem6.SetActive(true);
          GemPanel6.transform.position= new Vector2 (x_p,y_p);
          x_g=x_g+step_g;
          x_p=x_p+step_p;
        }
        if(ab7==true)
        {
          Gem7.transform.position= new Vector2 (x_g,y_g);
          Gem7.SetActive(true);
          GemPanel7.transform.position= new Vector2 (x_p,y_p);
          x_g=x_g+step_g;
          x_p=x_p+step_p;
        }
        if(ab8==true)
        {
          Gem8.transform.position= new Vector2 (x_g,y_g);
          Gem8.SetActive(true);
          GemPanel8.transform.position= new Vector2 (x_p,y_p);
          x_g=x_g+step_g;
          x_p=x_p+step_p;
        }
        if(ab9==true)
        {
          Gem9.transform.position= new Vector2 (x_g,y_g);
          Gem9.SetActive(true);
          GemPanel9.transform.position= new Vector2 (x_p,y_p);
          x_g=x_g+step_g;
          x_p=x_p+step_p;
        }
        if(ab10==true)
        {
          Gem10.transform.position= new Vector2 (x_g,y_g);
          Gem10.SetActive(true);
          GemPanel10.transform.position= new Vector2 (x_p,y_p);
          x_g=x_g+step_g;
          x_p=x_p+step_p;
        }
        
    }

    void Update()
    {
        if(mana>=20)
        {
            mana=20;
        }
      ManaText.text = mana.ToString();
      if(hl>0)
      {hm.gameObject.GetComponent<Animator>().SetBool("heal",true);}
      else{hm.gameObject.GetComponent<Animator>().SetBool("heal",false);hl=0;}

      if(kislota>0)
      {tm.gameObject.GetComponent<Animator>().SetBool("Toxicact",true);}
      else{tm.gameObject.GetComponent<Animator>().SetBool("Toxicact",false);kislota=0;}

      if(silens>0)
      { fm.gameObject.GetComponent<Animator>().SetBool("silens", true); Player.gameObject.GetComponent<Animator>().SetBool("idle",true); }
      else{fm.gameObject.GetComponent<Animator>().SetBool("silens",false); Player.gameObject.GetComponent<Animator>().SetBool("idle",false); }

      if(boost>1&&silens<=0)
      {fm.gameObject.GetComponent<Animator>().SetBool("SlShit",true);}
      else{fm.gameObject.GetComponent<Animator>().SetBool("SlShit",false);}

      if(silens>0&&boost>1)
      {fm.gameObject.GetComponent<Animator>().SetBool("sl+sh",true);}
      else{fm.gameObject.GetComponent<Animator>().SetBool("sl+sh",false);}
      if(ssh>0)
      {hm.gameObject.GetComponent<Animator>().SetBool("Sshild",true);}
      else{hm.gameObject.GetComponent<Animator>().SetBool("Sshild",false);ssh=0;}
      /*if(ssh>0&&hl>0)
      {hm.gameObject.GetComponent<Animator>().SetBool("hl+ssh",true);}
      else{hm.gameObject.GetComponent<Animator>().SetBool("hl+ssh",false);}*/

      //Debug.Log(TimeBtw); idle
        if(Eh<=0)
        {
          Canvas.SetActive(false);
          kristal.SetActive(false);
          Player.gameObject.GetComponent<Animator>().SetTrigger("fly");
          Fight=false;
             if (TimeBt <= 0)
            {
                LoadScreen.SetActive(true);
                SceneManager.LoadScene(5);
                
            }
            else
            {
                TimeBt -= 1;
            }
        }
      if(Fight==true)
      {
        if (Plf == true)
        {
                sox = true;
                lapka = true;
        }
        if (Enf == true)
        {
          enemyf();
        }
        

      }
    }
    void enemyf()
    {
        if(sox==true)
        {
        Random rnd = new Random();
        value = rnd.Next(0, 3);
            silens--;
            if(hl>0)
            {
                hp = hp + 5;
                currentHealthPlayer += 5;
                healthBarPl.SetHealth(currentHealthPlayer);
            }
            hl = hl - 1;
            sox = false;
        }
        

        if (value == 0|| value == 1)
        {
            if (silens <= 0)
            {
                Player.gameObject.GetComponent<Animator>().SetTrigger("takedmg");
                
                if (lapka == true)
                {
                  //SoundManagerScript.PlaySound("DragonClaw");
                  lapka = false;
                }
                
            }
            if (TimeBtwFight <= 0)
            {

                Plf = true;
                Enf = false;
                mana = mana + 4;
                Eh = Eh - kislotadmg;
                currentHealth -= kislotadmg*boost;
                healthBar.SetHealth(currentHealth);
                kislota--;
                if (silens <= 0)
                {
                    if (ssh <= 0)
                    {
                        hp = hp - endmg;
                        currentHealthPlayer -= endmg;
                        healthBarPl.SetHealth(currentHealthPlayer);
                        
                        Bedmg = endmg;
                    }
                    else { ssh = ssh - endmg; }
                }
                else { Player.gameObject.GetComponent<Animator>().SetTrigger("idle"); }
                TimeBtwFight = StartTimeBtwFight;
            }
            else
            {
                TimeBtwFight -= Time.deltaTime;
            }
        }
        if (value == 2)
        {
            if (silens <= 0)
            {
                Player.gameObject.GetComponent<Animator>().SetTrigger("takedmgfire");
                
                if (lapka == true)
                {
                  //SoundManagerScript.PlaySound("DragonBeem");
                  lapka = false;
                }
                
            }
            if (TimeBtwFight <= 0)
            {

                Plf = true;
                Enf = false;
                mana = mana + 4;
                Eh = Eh - kislotadmg * boost;
                currentHealth -= kislotadmg * boost;
                healthBar.SetHealth(currentHealth);
                kislota--;
                if (silens <= 0)
                {
                    if (ssh <= 0)
                    {
                        hp = hp - endmg - 2;
                        currentHealthPlayer -= endmg;
                        currentHealthPlayer -= 2;
                        healthBarPl.SetHealth(currentHealthPlayer);
                        Bedmg = endmg + 2;
                    }
                    else { ssh = ssh - endmg - 2; }
                }
                else { Player.gameObject.GetComponent<Animator>().SetTrigger("idle"); }
                TimeBtwFight = StartTimeBtwFight;
            }
            else
            {
                TimeBtwFight -= Time.deltaTime;
            }
        }

    }
    
    public void fb()
    {
      if (Plf == true && mana >= 8)
      {
          mana = mana - 8;
        pldmg=16;
        currentHealth -= pldmg*boost;
        healthBar.SetHealth(currentHealth);
          Eh = Eh - pldmg*boost;
          Plf = false;
          Enf = true;
          Player.gameObject.GetComponent<Animator>().SetTrigger("fire");
          SoundManagerScript.PlaySound("FireBall");
          boost=1;
      }
      
    }
    public void sl()
    {
      if (Plf == true && mana >= 8)
      {
       silens = 3;
       Player.gameObject.GetComponent<Animator>().SetTrigger("salo");
       SoundManagerScript.PlaySound("Silance");
       fm.gameObject.GetComponent<Animator>().SetTrigger("sl");
       mana=mana-8;
       Plf = false;
       Enf = true;
       boost=1;
      }
      
    }
    public void shit()
    {
      if (Plf == true && mana >= 6)
      {
          Player.gameObject.GetComponent<Animator>().SetTrigger("deffd");
          SoundManagerScript.PlaySound("BrakeShit");
        fm.gameObject.GetComponent<Animator>().SetTrigger("Sht");
        mana=mana-6;
        boost=2;
        Plf = false;
        Enf = true;
      }
      }
      
    public void st()
    {
      if (Plf == true && mana >= 4)
      {
        mana = mana - 4;
        pldmg=8;   
        currentHealth -= pldmg*boost;
        healthBar.SetHealth(currentHealth);
        Eh = Eh - pldmg*boost;
        Plf = false;
        Enf = true;
        Player.gameObject.GetComponent<Animator>().SetTrigger("stone");
        SoundManagerScript.PlaySound("Stone");
        boost=1;
      }
      
        
    }
    public void heal()
    {
      if (Plf == true && mana >= 4)
      {
          mana=mana-4;
        hl=3;
        Plf = false;
        Enf = true;
        silens=silens-1;
        SoundManagerScript.PlaySound("Heal");
        Player.gameObject.GetComponent<Animator>().SetTrigger("healup");
        
      }
      
    }
    public void timeRew()
    {
      if (Plf == true && mana >= 10)
      {
          mana = mana - 10;
          currentHealth -= Bedmg*boost;
          healthBar.SetHealth(currentHealth);
          Eh = Eh - Bedmg*boost;
          currentHealthPlayer += Bedmg;
          hp =hp+Bedmg*boost;
          healthBarPl.SetHealth(currentHealthPlayer);
          Plf = false;
          Enf = true;
          SoundManagerScript.PlaySound("Time");
          Player.gameObject.GetComponent<Animator>().SetTrigger("clock");
          
          boost=1;
      }
      
    }
    public void Ssh()
    {
      if (Plf == true && mana >= 10)
      {
        mana=mana-10;
        ssh=16;
        Plf = false;
        Enf = true;
        Player.gameObject.GetComponent<Animator>().SetTrigger("Enshild");
        SoundManagerScript.PlaySound("Ssh");
        boost=1;
        
      }
      
      
       
    }
    public void kislotaw()
    {
      if (Plf == true && mana >= 5)
      {
        mana=mana-5;
        kislotadmg=2;
        kislota=3;
        pldmg=4;
        currentHealth -= pldmg*boost;
        healthBar.SetHealth(currentHealth);
        Eh = Eh - pldmg*boost;
        tm.gameObject.GetComponent<Animator>().SetTrigger("Tox");
        SoundManagerScript.PlaySound("Kislota");
        Player.gameObject.GetComponent<Animator>().SetTrigger("Tox");
        Plf = false;
        Enf = true;
      }
      
    }
    public void molanka()
    {
      if (Plf == true && mana >= 12)
      {
        mana = mana - 12;
        pldmg=28;
        currentHealth -= pldmg*boost;
        healthBar.SetHealth(currentHealth);
         Eh = Eh - pldmg*boost;
         Plf = false;
         Enf = true;
         Player.gameObject.GetComponent<Animator>().SetTrigger("Lightning");
         SoundManagerScript.PlaySound("Molanka");
         boost=1;
      }
      
    }
    public void selfharm()
    {
      if (Plf == true && mana >= 0)
      {
        pldmg=6;
        currentHealthPlayer -= 3;
        healthBarPl.SetHealth(currentHealthPlayer);
        //hp = hp - endmg*boost;
        Bedmg=endmg;

        currentHealth -= pldmg*boost;
        healthBar.SetHealth(currentHealth);
        Eh = Eh - pldmg*boost;
        Plf = false;
        Enf = true;
        Player.gameObject.GetComponent<Animator>().SetTrigger("PsyBlade");
        SoundManagerScript.PlaySound("SelfHarm");
        boost=1;
      }
       
    }

    public void skipppa()
    {if (Plf == true)
        { 
      Plf = false;
      Enf = true;
      Player.gameObject.GetComponent<Animator>().SetTrigger("sleep");
        } 
      

    }
}
