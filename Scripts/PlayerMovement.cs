using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed = 100;
    public Rigidbody2D rb;
    public Animator animator;

    //add animator component to player gameobject and link to this script
    private void Update()
    {
        #region Animation
        //if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D)
        //   || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    animator.SetBool("MoveRight", false);
        //    animator.SetBool("MoveLeft", false);
        //    animator.SetBool("MoveUp", false);
        //    animator.SetBool("MoveDown", false);
        //}


        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //move left
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveLeft", true);
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveDown", false);
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            //move left

            animator.SetBool("MoveLeft", false);

        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            //move right
            animator.SetBool("MoveRight", true);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveDown", false);
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            //move right

            animator.SetBool("MoveRight", false);

        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            //move up
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveUp", true);
            animator.SetBool("MoveDown", false);
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            //move up

            animator.SetBool("MoveUp", false);

        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            //move down
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveLeft", false);
            animator.SetBool("MoveUp", false);
            animator.SetBool("MoveDown", true);
        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            //move down

            animator.SetBool("MoveDown", false);

        }

        #endregion
    }

    public void FixedUpdate()
    {
        
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
       
            
        //Time.maximumDeltaTime = 0.03f; //<<just over your estimated average frame time.
        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);




    }
   
}

