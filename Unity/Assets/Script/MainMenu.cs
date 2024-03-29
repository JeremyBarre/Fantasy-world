using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad;
    public GameObject settingWindow;

    public void StartGame()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void SettingButton()
    {
        settingWindow.SetActive(true);
    }

    public void CloseSettingWindow()
    {
        settingWindow.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
