using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 5f;
    // [SerializeField] float jumpForce = 5f;

    // [SerializeField] Transform groundCheck;
    // [SerializeField] LayerMask ground;
    // Start is called before the first frame update
    void Start()
    {
        // Physics.gravity = new Vector3(0, -10F, 0);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);

        // if(Input.GetButtonDown("Jump") && IsGrounded())
        // {
        //     rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        //     Physics.gravity = new Vector3(0, -30F, 0);
        // }

        //untuk putar karakter
        if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.D) || 
           Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.LeftArrow) 
           || Input.GetKey (KeyCode.RightArrow))
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(-89.706f, targetAngle - 90f, -90.004f);
        }
    }

    // bool IsGrounded()
    // {
    //     return Physics.CheckSphere(groundCheck.position, .1f, ground);
    // }
}
