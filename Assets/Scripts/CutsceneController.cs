using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using Cinemachine;

public class CutsceneController : MonoBehaviour
{
    public GameObject TimerCanvas;
    public GameObject CutSceneCamera;
    public GameObject PlayerFollowCamera;
    public GameObject MainCamera;
    
    public GameObject PlayerCapsule;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        // PlayerFollowCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
        {
            TimerCanvas.SetActive(true);
            MainCamera.GetComponent<Camera>().enabled = true;
            PlayerFollowCamera.SetActive(true);
            CutSceneCamera.GetComponent<Camera>().enabled = false;
            PlayerCapsule.GetComponent<PlayerController>().enabled = true;
            PlayerCapsule.GetComponent<CharacterController>().enabled = true;
            PlayerCapsule.GetComponent<StarterAssets.ThirdPersonController>().enabled = true;
            transform.gameObject.SetActive(false);
        }
    }
}
