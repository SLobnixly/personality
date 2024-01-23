using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanage : MonoBehaviour
{
    // when button is pressed load scene
    public void start2Player()
    {
        SceneManager.LoadScene("normal");
    }
    // when button is pressed load scene
    public void LvlSelect()
    {
        SceneManager.LoadScene("LvlSelect");
    }
    // when button is pressed load scene
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void Level4()
    {
        SceneManager.LoadScene("Level4");
    }
    public void Level5()
    {
        SceneManager.LoadScene("Level5");
    }
    public void Level6()
    {
        SceneManager.LoadScene("Level6");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }

}

