using UnityEngine;

public class Movement : MonoBehaviour
{
    private Player player;

    public bool Death;
   

    void Start()
    {
        // Get the Player script attached to the same GameObject
        player = GetComponent<Player>();
        
    }

    void Update()
    {
        // Listen for Space key press to trigger jumping
        if (Input.GetKeyDown(KeyCode.Space)&&Death==false)
        {
            player.Jump();
        }

        player.ResetPlayer();
        // Get the horizontal input (left/right or A/D keys)

        float moveInput = Input.GetAxisRaw("Horizontal"); // Returns -1 for left, 1 for right, and 0 for no input

        if (Death == false) { 
            player.Move(moveInput);
        }

   

    
    }



}
