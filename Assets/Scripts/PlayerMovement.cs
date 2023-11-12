using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Rigidbody rb;

    public float speed;
    public float defaultSpeed;
    public float gravity = -9.81f;

    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = -0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    float timer;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "car")
        {
            speed = 0f;
            defaultSpeed = 0f;
        }
    }


    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
            
        }

        //Game over when player fall down

        if (rb.position.y < -2f) 
        {
            FindObjectOfType<GameManager>().GameOver();
        }

        //lower speed when jumping

        if (!isGrounded)
        {
            speed = defaultSpeed * 0.7f;
        }

        if (isGrounded)
        {
            speed = defaultSpeed;
        }

        //animations
        bool checkmove;
        if (Input.GetButton("Vertical"))
            checkmove = true;
        else checkmove = false;

        if (checkmove == true)
            anim.SetBool("checkMove", true);
        if (checkmove == false)
            anim.SetBool("checkMove", false);


        //movement

         float x = 0f;
         float z = Input.GetAxisRaw("Vertical");

         Vector3 move = transform.right * x + transform.forward * z;
         controller.Move(move * speed * Time.deltaTime);


        //jumping

        if (Input.GetButtonDown("Jump") && isGrounded )
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        // adds gravity

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}
