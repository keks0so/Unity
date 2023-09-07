using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    

    public void nextscene()
    {
        SceneManager.LoadScene(2);
    }

    public void exit()
    {
        Application.Quit();
    }

}
