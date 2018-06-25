using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System.IO;
public class MainMenu : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene("Game");
	}
	public void QuitGame ()
	{
		Debug.Log("quit! unsub pls");
		Application.Quit();
		
		/*string filePath = @"F:\TheCovenProphecy\TheCovenProphecy\Assets\Scripts\MenuBeforeOptions.txt";
		
		List<string> lines = File.ReadAllLines(filePath).ToList();
		
		foreach (string line in lines)
		{
			Debug.Log(line);
		}*/
		
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

/*public class HandleTextFile
{
    [MenuItem("Tools/Write file")]
    static void WriteString()
    {
        string path = "Assets/Scripts/MenuBeforeOptions.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("MainMenu");
        writer.Close();

        //Re-import the file to update the reference in the editor
        AssetDatabase.ImportAsset(path); 
        TextAsset asset = Resources.Load("mainMenu");

        //Print the text from the file
        Debug.Log(asset.text);
    }

    [MenuItem("Tools/Read file")]
    static void ReadString()
    {
        string path = "Assets/Scripts/MenuBeforeOptions.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path); 
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }

}*/