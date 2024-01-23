using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eindetimer : MonoBehaviour
{
    float timing = 3;
    void Update()
    {
        if (timing > 0)
        {
            timing -= Time.deltaTime;
        }
        else
        {
            QuitGame();
        }

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
