using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int score; 
    

    

    public string sceneNameFake;

    public string sceneNameReal;


    public void Start()
    {
        if (SceneManager.GetActiveScene().name == "Post1")
        {
            PlayerPrefs.SetInt("Score", 0);
        }
    }

    public void LoadNext()
    {
        SceneManager.LoadScene(sceneNameReal);
    }

    public void LoadSpecificSceneReal()
    {
        PlayerPrefs.SetInt("Real",1);
        PlayerPrefs.SetInt("Fake",0);
        SceneManager.LoadScene(sceneNameReal);
    }

    

    public void LoadSpecificSceneFake()
    {
        PlayerPrefs.SetInt("Fake",1);
        PlayerPrefs.SetInt("Real",0);
        SceneManager.LoadScene(sceneNameFake);
    }
}

