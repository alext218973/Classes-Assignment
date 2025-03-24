using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameMenu : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadSceneAsync("Game Level");
    }

}