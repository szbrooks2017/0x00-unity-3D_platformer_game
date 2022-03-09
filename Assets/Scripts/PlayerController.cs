using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
     public float threshold;
     public AudioSource step, land;

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
     void FixedUpdate () {
         if (transform.position.y < threshold)
             transform.position = new Vector3(0, 20, 0);
     }

    //  private void Awake()
    //  {
    //      step = GetComponent<AudioSource>();
    //  }
     
     private void Step()
     {
         step.Play();
     }

     private void Land()
     {
         land.Play();
     }
}
