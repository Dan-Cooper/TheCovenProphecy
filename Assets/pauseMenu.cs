using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {
    //bool to determine if game is paused, false by default
    public static bool gamePaused = false;

    //game reference
    public GameObject pauseMenuUI;

    //Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (gamePaused) {
                resume();
            }
            else {
                pause();
            }
        }
    }

    //resume function
    public void resume() {
        //set the UI to inactive
        pauseMenuUI.SetActive(false);

        //time scale to normal
        Time.timeScale = 1f;

        //set var to false
        gamePaused = false;
    }

    //pause function
    void pause() {
        //console output
        Debug.Log("...Loading menu...");

        //set the UI to active
        pauseMenuUI.SetActive(true);

        //time scale to 0, pause
        Time.timeScale = 0f;

        //set var to true
        gamePaused = true;
    }

    //load the menu
    public void loadMenu() {
        //console output
        Debug.Log("...Loading menu...");

        //load menu scene
        SceneManager.LoadScene("MainMenu00");

        //time scale to normal
        Time.timeScale = 1f;
    }

    //exit game
    public void quitGame() {
        Debug.Log("...Quitting game...");
        Application.Quit();
    }
}