using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string StageScene;

    void OnMouseDown()
    {
        StageScene = "StageScene";
        SceneManager.LoadScene(StageScene);
    }
}
