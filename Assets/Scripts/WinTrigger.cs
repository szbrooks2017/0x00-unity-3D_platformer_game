using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Text TimerText;
    public GameObject Player;
    public GameObject WinCanvas;
    public AudioSource BGM;
    public AudioSource sting;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Player.GetComponent<Timer>().enabled = false;
            Player.GetComponent<Timer>().Win();
            WinCanvas.SetActive(true);
            BGM.Stop();
            sting.Play();
        }
    }

    
}
