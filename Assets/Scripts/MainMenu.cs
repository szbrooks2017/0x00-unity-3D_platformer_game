using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public AudioMixer master;
    void Start()
    {
        if (PlayerPrefs.HasKey("bgmvol"))
        {
            master.SetFloat("bgmvol", Mathf.Log10(PlayerPrefs.GetFloat("bgmvol")) * 20);
        }
            if (PlayerPrefs.HasKey("sfxvol"))
        {
            master.SetFloat("sfxvol", Mathf.Log10(PlayerPrefs.GetFloat("sfxvol")) * 20);
        }
    }

    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Options()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("Back", SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Exited");
    }
}
