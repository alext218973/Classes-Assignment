using UnityEngine;

public class Player : MonoBehaviour
{
    public int jumpForce = 10; // Jump force value that can be adjusted in Unity

    private Rigidbody2D rb; // Reference to Rigidbody2D component

    // This will be called when the script is initialized
    void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    // Method to handle jump logic
    public void Jump()
    {
        // Change the Y velocity to make the player jump
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }
}