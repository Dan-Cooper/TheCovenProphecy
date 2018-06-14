using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene("Game");
	}
	public void QuitGame ()
	{
		Debug.Log("quit! unsub pls");
		Application.Quit();
	}
	public void OptionsMenu ()
	{
		SceneManager.LoadScene("Options");
	}
	public void getActiveScene ()
	{
		Scene scene = SceneManager.GetActiveScene();
		Debug.Log(scene.name);
	}
	
}