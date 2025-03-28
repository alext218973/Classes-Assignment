using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsButtonUI : MonoBehaviour
{
    [SerializeField] private string _toInstructions = "Instructions";

    public void ToInstructions()
    {
        SceneManager.LoadScene(_toInstructions);
    }
}

public class Program2
{
    public static void Main(string[] args)
    {
        InstructionsButtonUI button = new InstructionsButtonUI();

        button.ToInstructions();
    }
}