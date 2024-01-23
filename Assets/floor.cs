using UnityEngine;
using UnityEngine.SceneManagement;

public class floor : MonoBehaviour
{
    public string nextLevelName;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("First Person Controller"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}