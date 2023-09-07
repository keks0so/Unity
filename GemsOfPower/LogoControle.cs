using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class LogoControle : MonoBehaviour
{
    public int TimeBtw;
    private bool check = false;

    void Start()
    {
        TimeBtw = 550;
        //char[] alpha = { 'A', 'B', 'C', 'D', 'E', 'F' };
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        string fileName = "POPO.txt";

        for (int i = 0; i < alpha.Length; ++i)
        {
            string path = alpha[i] + ":/" + fileName;
            if (File.Exists(path))
            {
                check = true;
                break; // Exit the loop if file found in any drive
            }
        }
    }

    void Update()
    {
        if (TimeBtw <= 0)
        {
            if (check)
            {
                SceneManager.LoadScene(1);
            }
            else
            {
                SceneManager.LoadScene(6);
            }
        }
        else
        {
            TimeBtw -= 1;
        }
    }
}
