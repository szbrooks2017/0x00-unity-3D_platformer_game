using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinMenu : MonoBehaviour
{
    // public Text TimerText;
    // public Text finalText;
    // private int level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // void Update()
    // {
    //     winText = TimerText;
    // }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void Next()
    {
        if (SceneManager.GetActiveScene().name == "Level03")
        {
            MainMenu();
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
