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
    }
}