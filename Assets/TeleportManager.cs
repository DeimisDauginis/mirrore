using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    // Time in seconds before teleporting
    private float teleportTime = 180f; // 3 minutes

    void Start()
    {
        // Invoke the TeleportToNewScene method after the specified time
        Invoke("TeleportToNewScene", teleportTime);
    }

    void TeleportToNewScene()
    {
        // Change "YourSceneName" to the name of the scene you want to teleport to
        SceneManager.LoadScene("Intro");
    }
}
