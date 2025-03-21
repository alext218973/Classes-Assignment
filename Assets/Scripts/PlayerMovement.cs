using System;
using UnityEngine;

public class Player
{
    public int jumpForce = 10;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    // Constructor to initialize the Player with necessary components
    public Player(Rigidbody2D rb, SpriteRenderer spriteRenderer)
    {
        this.rb = rb;
        this.spriteRenderer = spriteRenderer;
    }

    // Method for handling jump logic
    public void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); // Jump by setting the Y velocity
    }
}

public class Movement : MonoBehaviour
{
    [SerializeField] float jumpForce = 10f; // Adjust the jump force if needed

    private Player player;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Create the Player instance and pass the Rigidbody2D and SpriteRenderer
        player = new Player(rb, spriteRenderer);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Jump(); // Call the Jump method from the Player class
        }
    }
}
