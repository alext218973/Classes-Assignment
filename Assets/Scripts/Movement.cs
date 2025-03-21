using UnityEngine;

public class Movement : MonoBehaviour
{
    private Player player; // Reference to the Player component

    void Start()
    {
        // Get the Player script attached to the same GameObject
        player = GetComponent<Player>();
    }

    void Update()
    {
        // Listen for Space key press to trigger jumping
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Jump();  // Call the Jump method from Player class
        }

        // Get the horizontal input (left/right or A/D keys)
        float moveInput = Input.GetAxisRaw("Horizontal"); // Returns -1 for left, 1 for right, and 0 for no input

        // Call the Move method from the Player class to handle movement
        player.Move(moveInput);
    }
}
