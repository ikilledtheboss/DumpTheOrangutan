using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameVote : MonoBehaviour
{
    public GameObject self, Curtain;
    string NextGame;

    void Start()
    {
        Curtain.GetComponent<UpFlag>().enabled = true;
    }

    public void AnyoneWins()
    {
        NextGame = "LoseScreen";
        SceneManager.LoadScene(NextGame);
    }

    public void DumpWins()
    {
        NextGame = "WinScreen";
        SceneManager.LoadScene(NextGame);
    }
}
