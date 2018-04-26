using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restarter : MonoBehaviour
{
    public string NextGame;

    public void Restarting()
    {
        NextGame = "MainMenu";
        SceneManager.LoadScene(NextGame);
    }
}