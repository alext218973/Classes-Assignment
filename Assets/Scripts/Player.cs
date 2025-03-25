using UnityEngine;

public class Player : MonoBehaviour
{
    public int jumpForce = 10;
    public float moveSpeed = 5f;
    public LayerMask groundLayer;
    private SpriteRenderer sr;
    private Rigidbody2D rb;
    private bool isGrounded;


    private Animator anim;
    private string Run_ANIMATION = "run";
    private string Jump_Animation = "jump";

    void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject
        rb = GetComponent<Rigidbody2D>();
        //Get animator component
        anim = GetComponent<Animator>();

        sr=GetComponent<SpriteRenderer>();
    }

    // Method to handle jump logic
    public void Jump()
    {
        // Check if the player is on the ground before jumping
        if (isGrounded)
        {
            // Change Y velocity to make the player jump
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            //jumping animation
            anim.SetBool(Jump_Animation, true);
        }
    }

    // Method to handle left-right movement
    public void Move(float moveInput)
    {
        // Move the player by setting the Rigidbody2D velocity (keep the current Y velocity)
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);


        if (moveInput > 0)
        {
            anim.SetBool(Run_ANIMATION, true);

            sr.flipX = false;
        }
        else if (moveInput < 0)
        {
            anim.SetBool(Run_ANIMATION, true);
            sr.flipX = true;
        }
        else
        {
            anim.SetBool(Run_ANIMATION, false);

        }
    }

    // Detect collision with ground
    private void OnCollisionStay2D(Collision2D collision)
    {
        // Check if the player is touching the ground layer
        if (((1 << collision.gameObject.layer) & groundLayer) != 0)
        {
            isGrounded = true;

            //jumping animation
            anim.SetBool(Jump_Animation, false);

        }
    }

    // Detect when the player stops touching the ground
    private void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the player stops touching the ground layer
        if (((1 << collision.gameObject.layer) & groundLayer) != 0)
        {
            isGrounded = false;
            anim.SetBool(Jump_Animation, true);
        }
    }



}

