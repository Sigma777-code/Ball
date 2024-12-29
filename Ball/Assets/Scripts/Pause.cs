using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pause_Corner;
    public GameObject pause_Image;
    

    public void PauseOn()
    {
        pause_Image.SetActive(true);
        pause_Corner.SetActive(false);
        Time.timeScale = 0f;
    }

    public void PauseOff()
    {
        pause_Image.SetActive(false);
        pause_Corner.SetActive(true);
        Time.timeScale = 1.0f;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
