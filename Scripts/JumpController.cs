using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    public Animator animator;
    private bool animationStopped = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.StopPlayback();
    }

    public void ControlAnimation()
    {
        //Debug.Log("Button pressed");

        if (animationStopped)
        {
            animator.StartPlayback();
        }
        else
        {
            animator.StopPlayback();
        }

        // Toggle the animationStopped variable for the next press
        animationStopped = !animationStopped;
    }
}
