using UnityEngine;
using UnityEngine.SceneManagement; // Required for loading scenes

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        // Loads the scene with index 1 or named "GameScene"
        SceneManager.LoadScene(1);
    }
}