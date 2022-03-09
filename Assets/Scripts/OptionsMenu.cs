using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer master;
    public Slider BGMSlider;
    public Slider SFXSlider;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("bgmvol"))
        {
            BGMSlider.value = PlayerPrefs.GetFloat("bgmvol");
        }
            if (PlayerPrefs.HasKey("sfxvol"))
        {
            SFXSlider.value = PlayerPrefs.GetFloat("sfxvol");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Apply()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Back"));
        PlayerPrefs.SetFloat("bgmvol", BGMSlider.value);
        PlayerPrefs.SetFloat("sfxvol", SFXSlider.value);
    }

    public void Back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Back"));
    }
    public void SetSfxLvl(float sfxlvl)
    {
        master.SetFloat("sfxvol", Mathf.Log10(sfxlvl) * 20);
    }
    public void SetBgmLvl(float bgmlvl)
    {
        master.SetFloat("bgmvol", Mathf.Log10(bgmlvl) * 20);
    }
}
