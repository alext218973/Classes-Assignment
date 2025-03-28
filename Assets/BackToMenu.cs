using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonUI : MonoBehaviour
{
    [SerializeField] private string _backToMenu = "Main Menu";

    public void BackToMenu()
    {
        SceneManager.LoadScene(_backToMenu);
    }
}

public class Program1
{
    public static void Main(string[] args)
    {
        BackButtonUI button = new BackButtonUI();

        button.BackToMenu();
    }
}