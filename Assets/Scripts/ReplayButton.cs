using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButton : MonoBehaviour {
    [SerializeField] private string newGameLevel = "Game Level";

    public void NewGameButton() {
        SceneManager.LoadScene(newGameLevel);
    }
}
