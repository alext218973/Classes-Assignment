using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenuButton : MonoBehaviour {
    [SerializeField] private string newMainMenu = "Main Menu";

    public void NewGameButton() {
        SceneManager.LoadScene(newMainMenu);
    }
}
