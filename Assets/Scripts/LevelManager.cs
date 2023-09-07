using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Button Level1;
    public Button Level2;
    public Button Level3;
    public Button Level4;
    public Button Level5;
    public Button Level6;
    public Button Level7;
    public Button Level8;
    public Button Level9;
    public Button Level10;

    private void Start()
    {
        SetButtons();
        DefaultSettings();
        CeckProgres();
    }
    private void DefaultSettings()
    {
        Level2.interactable = false;
        Level3.interactable = false;
        Level4.interactable = false;
        Level5.interactable = false;
        Level6.interactable = false;
        Level7.interactable = false;
        Level8.interactable = false;
        Level9.interactable = false;
        Level10.interactable = false;
    }
    private void CeckProgres()
    {
        if (GlobalManager.Instance.progres >= 2)
        {
            Level2.interactable = true;
        }
        if (GlobalManager.Instance.progres >= 3)
        {
            Level3.interactable = true;
        }
        if (GlobalManager.Instance.progres >= 4)
        {
            Level4.interactable = true;
        }
        if (GlobalManager.Instance.progres >= 5)
        {
            Level5.interactable = true;
        }
        if (GlobalManager.Instance.progres >= 6)
        {
            Level6.interactable = true;
        }
        if (GlobalManager.Instance.progres >= 7)
        {
            Level7.interactable = true;
        }
        if (GlobalManager.Instance.progres >= 8)
        {
            Level8.interactable = true;
        }
        if (GlobalManager.Instance.progres >= 9)
        {
            Level9.interactable = true;
        }
        if (GlobalManager.Instance.progres >= 10)
        {
            Level10.interactable = true;
        }
    }
    private void SetButtons()
    {
        Level1.onClick.AddListener(() =>
        {
            LoadLevel("Level 1");
            GlobalManager.Instance.curentLevel = 1;
            // GlobalManager.Instance.score = 10;
            Time.timeScale = 1f;
        });
        Level2.onClick.AddListener(() =>
        {
            LoadLevel("Level 2");
            GlobalManager.Instance.curentLevel = 2;
            // GlobalManager.Instance.score = 10;
            Time.timeScale = 1f;
        });
        Level3.onClick.AddListener(() =>
        {
            LoadLevel("Level 3");
            GlobalManager.Instance.curentLevel = 3;
            // GlobalManager.Instance.score = 20;
            Time.timeScale = 1f;
        });
        Level4.onClick.AddListener(() =>
        {
            LoadLevel("Level 4");
            GlobalManager.Instance.curentLevel = 4;
            // GlobalManager.Instance.score = 20;
            Time.timeScale = 1f;
        });
        Level5.onClick.AddListener(() =>
        {
            LoadLevel("Level 5");
            GlobalManager.Instance.curentLevel = 5;
            GlobalManager.Instance.score = 30;
            Time.timeScale = 1f;
        });
        Level6.onClick.AddListener(() =>
        {
            LoadLevel("Level 6");
            GlobalManager.Instance.curentLevel = 6;
            // GlobalManager.Instance.score = 20;
            Time.timeScale = 1f;
        });
        Level7.onClick.AddListener(() =>
        {
            LoadLevel("Level 7");
            GlobalManager.Instance.curentLevel = 7;
            // GlobalManager.Instance.score = 20;
            Time.timeScale = 1f;
        });
        Level8.onClick.AddListener(() =>
        {
            LoadLevel("Level 8");
            GlobalManager.Instance.curentLevel = 8;
            // GlobalManager.Instance.score = 30;
            Time.timeScale = 1f;
        });
        Level9.onClick.AddListener(() =>
        {
            LoadLevel("Level 9");
            GlobalManager.Instance.curentLevel = 9;
            // GlobalManager.Instance.score = 30;
            Time.timeScale = 1f;
        });
        Level10.onClick.AddListener(() =>
        {
            LoadLevel("Level 10");
            GlobalManager.Instance.curentLevel = 10;
            // GlobalManager.Instance.score = 40;
            Time.timeScale = 1f;
        });
    }
    private void LoadLevel(string levelName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(levelName);
    }

}