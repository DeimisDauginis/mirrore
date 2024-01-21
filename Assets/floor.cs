using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    private void Start()
    {
        // Any initialization code you want to run when the script starts
    }

    private void Update()
    {
        // Any code you want to run every frame
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with an object named "Floor"
        if (collision.gameObject.name == "Floor")
        {
            // Restart the current scene
            RestartScene();
        }
    }

    private void RestartScene()
    {
        // Get the current active scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Reload the current scene
        SceneManager.LoadScene(currentSceneIndex);
    }
}