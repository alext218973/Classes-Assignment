using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour {
    [SerializeField] private string _newGameLevel = "Game Level";

    public void NewGameButton() {
        SceneManager.LoadScene(_newGameLevel);
    }
}

public class Program { 
    public static void Main(string[] args) {
        ButtonUI button = new ButtonUI();

        button.NewGameButton();
    }
}