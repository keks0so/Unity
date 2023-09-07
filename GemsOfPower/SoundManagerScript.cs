using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip DragonClawSound, DragonBeemSound, FireBallSound, HealSound, TimeRewSound, KislotaSound, SshSound, SelfHarmSound, MolankaSound, StoneSound, SilanceSound, BrakeShitSound; 
    public static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        DragonClawSound = Resources.Load<AudioClip>("lapka");
        DragonBeemSound = Resources.Load<AudioClip>("good rik 2");


        FireBallSound = Resources.Load<AudioClip>("FireBall");
        HealSound = Resources.Load<AudioClip>("Heal");
        TimeRewSound = Resources.Load<AudioClip>("za warudo");
        KislotaSound = Resources.Load<AudioClip>("Kislota");
        SshSound = Resources.Load<AudioClip>("Shild");
        SelfHarmSound = Resources.Load<AudioClip>("Knife");
        MolankaSound = Resources.Load<AudioClip>("Lightning");
        StoneSound = Resources.Load<AudioClip>("Stone");
        SilanceSound = Resources.Load<AudioClip>("Silance");
        BrakeShitSound = Resources.Load<AudioClip>("ShildBr");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "DragonClaw":
        
                audioSrc.PlayOneShot (DragonClawSound);
                break;
            case "DragonBeem":
                
                audioSrc.PlayOneShot (DragonBeemSound);
                break;


            case "FireBall":
                audioSrc.PlayOneShot (FireBallSound);
                break;
            case "Heal":
                audioSrc.PlayOneShot (HealSound);
                break;
            case "Time":
                audioSrc.PlayOneShot (TimeRewSound);
                break;
            case "Kislota":
                audioSrc.PlayOneShot (KislotaSound);
                break;
            case "Ssh":
                audioSrc.PlayOneShot (SshSound);
                break;
            case "SelfHarm":
                audioSrc.PlayOneShot (SelfHarmSound);
                break;
            case "Molanka":
                audioSrc.PlayOneShot (MolankaSound);
                break;
            case "Stone":
                audioSrc.PlayOneShot (StoneSound);
                break;
            case "Silance":
                audioSrc.PlayOneShot (SilanceSound);
                break;
            case "BrakeShit":
                audioSrc.PlayOneShot (BrakeShitSound);
                break;
        }
    }
}
