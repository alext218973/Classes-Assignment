using UnityEngine;

public class Player : MonoBehaviour
{
    public int jumpForce = 10;  // Jump force for the player
    public float moveSpeed = 5f; // Movement speed for the player
    public LayerMask groundLayer; // The layer that represents the ground

    private Rigidbody2D rb; // Reference to the Rigidbody2D component
    private bool isGrounded; // Check if player is on the ground

    void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    // Method to handle jump logic
    public void Jump()
    {
        // Check if the player is on the ground before jumping
        if (isGrounded)
        {
            // Change Y velocity to make the player jump
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    // Method to handle left-right movement
    public void Move(float moveInput)
    {
        // Move the player by setting the Rigidbody2D velocity (keep the current Y velocity)
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }

    // Detect collision with ground
    private void OnCollisionStay2D(Collision2D collision)
    {
        // Check if the player is touching the ground layer
        if (((1 << collision.gameObject.layer) & groundLayer) != 0)
        {
            isGrounded = true; // The player is grounded
        }
    }

    // Detect when the player stops touching the ground
    private void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the player stops touching the ground layer
        if (((1 << collision.gameObject.layer) & groundLayer) != 0)
        {
            isGrounded = false; // The player is no longer grounded
        }
    }
}

