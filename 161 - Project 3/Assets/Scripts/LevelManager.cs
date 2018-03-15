using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    private void Awake()
    {
        Time.timeScale = 1f;
    }

    public void MoveScene(int level)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(level);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            Restart();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void GameOver()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }


}
