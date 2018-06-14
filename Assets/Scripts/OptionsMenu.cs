using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour {
	Scene lastScene;
	void Start()
    {
		lastScene = SceneManager.GetActiveScene();
        Debug.Log("Active scene is '" + lastScene.name + "'.");
    }

	/*
	void Update () {
		if(currentScene == SceneManager.GetActiveScene()){
			Debug.Log("Same Scene");
			} else {
				lastScene = currentScene;
				currentScene = SceneManager.GetActiveScene();
			}
		}
	*/

	public void GoBack ()
	{
		if(lastScene.name == "MainMenu00"){
			SceneManager.LoadScene("MainMenu00");
		}
		if(lastScene.name == "Game"){
			SceneManager.LoadScene("Game");
		}
	}	
}