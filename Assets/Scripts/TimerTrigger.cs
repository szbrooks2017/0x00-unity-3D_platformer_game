using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    public GameObject Player;

    void Start()
    {
        Player.gameObject.GetComponent<Timer>().enabled = false;
    }
    
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Player.gameObject.GetComponent<Timer>().enabled = true;
        }
    }
}
