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
        Level1.onClick.AddListener(() =>
        {
            LoadLevel("Level 1");
            GlobalManager.Instance.curentLevel = 1;
            GlobalManager.Instance.score = 10;
        });
        Level2.onClick.AddListener(() =>
        {
            LoadLevel("Level 2");
            GlobalManager.Instance.curentLevel = 2;
            GlobalManager.Instance.score = 10;
        });
        Level3.onClick.AddListener(() =>
        {
            LoadLevel("Level 3");
            GlobalManager.Instance.curentLevel = 3;
            GlobalManager.Instance.score = 20;
        });
        Level4.onClick.AddListener(() =>
        {
            LoadLevel("Level 4");
            GlobalManager.Instance.curentLevel = 4;
            GlobalManager.Instance.score = 20;
        });
        Level5.onClick.AddListener(() =>
        {
            LoadLevel("Level 5");
            GlobalManager.Instance.curentLevel = 5;
            GlobalManager.Instance.score = 30;
        });
        Level6.onClick.AddListener(() =>
        {
            LoadLevel("Level 6");
            GlobalManager.Instance.curentLevel = 6;
            GlobalManager.Instance.score = 20;
        });
        Level7.onClick.AddListener(() =>
        {
            LoadLevel("Level 7");
            GlobalManager.Instance.curentLevel = 7;
            GlobalManager.Instance.score = 20;
        });
        Level8.onClick.AddListener(() =>
        {
            LoadLevel("Level 8");
            GlobalManager.Instance.curentLevel = 8;
            GlobalManager.Instance.score = 30;
        });
        Level9.onClick.AddListener(() =>
        {
            LoadLevel("Level 9");
            GlobalManager.Instance.curentLevel = 9;
            GlobalManager.Instance.score = 30;
        });
        Level10.onClick.AddListener(() =>
        {
            LoadLevel("Level 10");
            GlobalManager.Instance.curentLevel = 10;
            GlobalManager.Instance.score = 40;
        });
    }
    private void LoadLevel(string levelName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(levelName);
    }

}