using UnityEngine;

public class Player : MonoBehaviour
{
    public int jumpForce = 10;  // Jump force for the player
    public float moveSpeed = 5f; // Movement speed for the player

    private Rigidbody2D rb; // Reference to the Rigidbody2D component

    void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    // Method to handle jump logic
    public void Jump()
    {
        // Change Y velocity to make the player jump
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }

    // Method to handle left-right movement
    public void Move(float moveInput)
    {
        // Move the player by setting the Rigidbody2D velocity (keep the current Y velocity)
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }
}
