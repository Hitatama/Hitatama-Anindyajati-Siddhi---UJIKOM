using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 10f;
    Rigidbody PlayerRB;
    Animator animator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal,0f,0f);
        PlayerRB.velocity = transform.TransformDirection(movement) * moveSpeed;

        if (Input.GetKeyDown("d"))
        {
            animator.SetTrigger("Right");
        }
        else
        {
            animator.SetTrigger("Idle");
        }

        if (Input.GetKeyDown("a"))
        {
            animator.SetTrigger("Left");
        }
        else
        {
            animator.SetTrigger("Idle");
        }


    }
}
