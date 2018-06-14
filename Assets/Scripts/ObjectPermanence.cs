using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectPermanence : MonoBehaviour
{
    private static bool created = false;

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
    }

    public void LoadScene()
    {
        if (SceneManager.GetActiveScene().name == "preload_")
        {
            SceneManager.LoadScene("MainMenu01", LoadSceneMode.Single);
        }
    }
}