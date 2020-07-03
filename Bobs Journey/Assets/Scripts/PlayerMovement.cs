using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public GameObject laser;
    public Animator animator;
    public float TimeBetweenShots;
    public float startTime;
    void Start()
    {
       
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        if (TimeBetweenShots <= 0)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                GameObject go = (GameObject)Instantiate(laser, transform.position, Quaternion.identity);
                go.GetComponent<MoveForward>().xSpeed = 0.1f; TimeBetweenShots = startTime;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {

                GameObject go = (GameObject)Instantiate(laser, transform.position, Quaternion.identity);
                go.GetComponent<MoveForward>().xSpeed = -0.1f; TimeBetweenShots = startTime;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {

                GameObject go = (GameObject)Instantiate(laser, transform.position, Quaternion.identity);
                go.GetComponent<MoveForward>().ySpeed = 0.1f; TimeBetweenShots = startTime;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {

                GameObject go = (GameObject)Instantiate(laser, transform.position, Quaternion.identity);
                go.GetComponent<MoveForward>().ySpeed = -0.1f; TimeBetweenShots = startTime;
            }
          
        }
        else
        {
            TimeBetweenShots -= Time.deltaTime;
        }

        

    }

   
void FixedUpdate()
    {
     
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
       
    }
}

