using UnityEngine;

public class Floor : MonoBehaviour
{
    // This function is called when the player collides with another object
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has a tag "DangerousObject"
        if (collision.gameObject.CompareTag("First Person Controller"))
        {
            // Call a function to handle player death (you can replace this with your own logic)
            Die();
        }
    }

    // Function to handle player death (replace this with your own death logic)
    private void Die()
    {
        Debug.Log("Player has died!"); // You can replace this with any death-related logic
        // For example, you might want to play an animation, display a game over screen, or reload the level.
    }
}