using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameVote : MonoBehaviour
{
    public GameObject self, ButtonWin, ButtonLose;
    string NextGame;

    void Start()
    {
        ButtonWin.GetComponent<Button>().enabled = true;
        ButtonLose.GetComponent<Button>().enabled = true;
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
