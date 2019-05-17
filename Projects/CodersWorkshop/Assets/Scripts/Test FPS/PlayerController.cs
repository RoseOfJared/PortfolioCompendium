using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  TODO: 
    Implement Dash Mechanic: 


 */
public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float gravity = 10.0f;
    public float jumpHeight = 2.0f;
    public float dashDistance = 5.0f;
    public float groundDistance = 0.2f;
    bool canJump = true;

    private Rigidbody rb;
    private Transform trans;
    private bool isGrounded = false;
    private Vector3 playerInput = Vector3.zero;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        trans= GetComponent<Transform>();
        //rb.freezeRotation = true;
        //rb.useGravity = false;
    }
    
    float CalculateJumpVerticalSpeed()
    {
        return Mathf.Sqrt(2 * jumpHeight * gravity);
    }

    private void OnCollisionStay(Collision other) {
        isGrounded = true;
    }

    void FixedUpdate() {
        if(isGrounded)
        {
            Vector3 targetVelocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            targetVelocity = transform.TransformDirection(targetVelocity);
            targetVelocity *= speed;

            Vector3 velocity = rb.velocity;
            Vector3 velocityChange = (targetVelocity - velocity);
            velocityChange.x = Mathf.Clamp(velocityChange.x, -10.0f, 10.0f);
            velocityChange.z = Mathf.Clamp(velocityChange.z, -10.0f, 10.0f);
            velocityChange.y = 0;

            rb.AddForce(velocityChange, ForceMode.VelocityChange);

            if(canJump && Input.GetButton("Jump"))
            {
                rb.velocity = new Vector3(velocity.x, CalculateJumpVerticalSpeed(), velocity.z);
            }
        }

        if(Input.GetButton("Fire1"))
        {
            //Fire gun, if one is equipped
        }

        rb.AddForce(new Vector3(0, -gravity * rb.mass, 0));

        isGrounded = false;
    } 

}
