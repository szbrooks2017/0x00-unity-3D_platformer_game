using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using StarterAssets;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    private bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    public AudioMixerSnapshot paused;
    public AudioMixerSnapshot unpaused;


    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                // unpaused.TransitionTo(0.01F);
                Resume();
            }
            else
            {
                // paused.TransitionTo(0.01F);
                Pause();
            }
        }
    }

    public void Pause()
    {
        // GameObject.Find("Player").GetComponent<StarterAssetsInputs>().SetCursorState(false);
		// GameObject.Find("Player").GetComponent<StarterAssetsInputs>().cursorLocked = false;
        // bring up pause menu
        // freeze time
        // change gameispaused variable to true
        
        //Cursor.lockState = CursorLockMode.None;
        GameIsPaused = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        paused.TransitionTo(0.01F);

    }

    public void Resume()
    {
        // Cursor.lockState = CursorLockMode.Locked;
        GameIsPaused = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        unpaused.TransitionTo(0.01F);
    }

    public void Restart()
    {
        Resume();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        Resume();
        SceneManager.LoadScene(0);
        unpaused.TransitionTo(0.01F);
    }

    public void Options()
    {
        Resume();
        SceneManager.LoadScene(1);
        unpaused.TransitionTo(0.01F);
    }

    // void WhilePauseMenuIsOn()
    // {
    //     Cursor.lockState = CursorLockMode.None;
    //     Cursor.visible = true;
    // }
}
