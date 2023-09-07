using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MazeSettings : MonoBehaviour
{
    public GameObject SettingsMenu;
    public int SetShit;
    // Start is called before the first frame update
    void Start()
    {
       SetShit = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.Escape))
        {
            
            
            if(SetShit == 1)
            {
                SettingsMenu.SetActive(true);
                SetShit = 0;
            }
            else
            {
                SettingsMenu.SetActive(false);
                SetShit = 1;
            }
            
            
        }
        
    }

    public void Settings720()
    {
        Screen.SetResolution(1280, 720, FullScreenMode.ExclusiveFullScreen, 60);
        
    }
    public void Settings1080()
    {
        Screen.SetResolution(1920, 1080, FullScreenMode.ExclusiveFullScreen, 60);
        
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
    public void Continue()
    {
        SettingsMenu.SetActive(false);
        
    }
    
}
