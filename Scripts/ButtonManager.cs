using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public bool gameStarted = false;
    public Canvas canvas;
    public Canvas panel;
    public bool pressed=false;

    public void NewGameBtn(string newGameLevel)
    {
        gameStarted = true;
        canvas.enabled = false;
        panel.enabled = false;
    }
    public void ExitGameBtn()
    {
        Application.Quit();
    }
}
