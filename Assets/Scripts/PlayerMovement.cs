using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 6f;
    public float defaultSpeed;
    public float gravity = -9.81f;

    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = -0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    /*Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    */

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (!isGrounded)
        {
            speed = defaultSpeed * 0.7f;
        }

        if (Input.GetKeyDown("s"))
        {
            speed = defaultSpeed * 0.5f;
        }

        if (isGrounded)
        {
            speed = defaultSpeed;
        }

        //animations

        //float checkMove = Input.GetAxis("Vertical")*5;
      //  anim.SetFloat("MovingSpeed", checkMove);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);


        if (Input.GetButtonDown("Jump") && isGrounded )
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}
