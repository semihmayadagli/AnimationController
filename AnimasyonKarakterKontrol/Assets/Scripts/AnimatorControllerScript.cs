using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControllerScript : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("Yurusun_mu",true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("Yurusun_mu", false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("Kossun_mu", true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            animator.SetBool("Kossun_mu", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Ziplasin_mi");
        }
        

    }
}
