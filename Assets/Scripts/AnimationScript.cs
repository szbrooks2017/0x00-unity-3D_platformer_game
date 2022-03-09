using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using StarterAssets;
public class AnimationScript : MonoBehaviour
{
    public Animator anim;
    public GameObject Player;

    void Start() {
        anim = GetComponent<Animator>();
        
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical");
        float rotation = Input.GetAxis("Horizontal");

        ThirdPersonController ground = Player.GetComponent<ThirdPersonController>();

        if (translation != 0 || rotation != 0)
        {
            anim.SetBool("IsRunning", true);
            // Debug.Log("i'm running");
        }
        else
        {
            anim.SetBool("IsRunning", false);
            // Debug.Log("i'm idle");
        }
        
        // (Input.GetKeyDown(KeyCode.Space))
        if (Player.GetComponent<StarterAssetsInputs>().jump == true)
        {
            anim.SetBool("IsJump", true);
            // Debug.Log("i'm jumping");
        }

        if (ground.Grounded == true)
        {
            anim.SetBool("IsJump", false);
            anim.SetBool("Falling", false);
        }
        else
        {
            anim.SetBool("Falling", true);
            anim.SetBool("IsRunning", false);
            Debug.Log("Bitch i'm falling");
        }
        // else
        // {
        //     anim.SetBool("IsJump", false);
        //     Debug.Log("i'm not jumping");
        // }

        // if (Player.transform.position.y <= (translation - 5))
        // if (Player.transform.position.y < -10)
        // {
        //     anim.SetBool("Falling", true);
        //     Debug.Log(Player.transform.position.y);
        // }

        // if (ground.grounded == true)
        // {

        // }
        // else
        // {
        //     anim.SetBool("Falling", true);
        // }
        
        // if (Player.transform.position.y > 0 && Player.transform.position.y < 5)
        // {
        //     anim.SetBool("Falling", false);
        // }
        // else
        // {
        //     anim.SetBool("Falling", true);
        // }
    }
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
