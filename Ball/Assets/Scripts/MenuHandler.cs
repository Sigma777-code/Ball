using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public GameObject levels;
    public GameObject menu;
    public void Play() 
    {
        menu.SetActive(false);
        levels.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Back()
    {
        menu.SetActive(true);
        levels.SetActive(false);
    }
    public void LoadLevels()
    {
        string buttonName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        int levelNumber =int.Parse (buttonName.Replace("Level ", " "));
        SceneManager.LoadScene (levelNumber);
    }
}
