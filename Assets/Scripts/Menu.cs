using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject levelSelection;
    public GameObject settings;

    public void OpenLevelSelection()
    {
        menu.SetActive(false);
        levelSelection.SetActive(true);
    }

    public void CloseLevelSelection()
    {
        levelSelection.SetActive(false);
        menu.SetActive(true);
    }

    public void OpenSettings()
    {
        menu.SetActive(false);
        settings.SetActive(true);
    }

    public void CloseSettings()
    {
        settings.SetActive(false);
        menu.SetActive(true);
    }

    public void PlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level 1");
    }

    public void ExitGame()
    {
        // Ieșiți din aplicație sau joc (funcționează în build-uri standalone)
        Application.Quit();
        Debug.LogError("quit");
    }
}
