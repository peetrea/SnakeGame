using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

[System.Serializable]
public class SaveData
{
    public int totalScore;
    public int progres;
}

public class GlobalManager : MonoBehaviour
{
    public static GlobalManager Instance { get; private set; }
    public int score;
    public int curentLevel;
    public int totalScore;
    public int progres;
    private ScoreDisplay scoreDisplay;

    private SaveData saveData;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            LoadGameData();
        }
    }

    public void GoToMenu()
    {
        SaveGameData();

        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }

    public void RestartCurrentScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    private void Update()
    {
        Debug.Log(totalScore);
    }

    private void SaveGameData()
    {
        saveData = new SaveData();
        saveData.totalScore = totalScore;
        saveData.progres = progres;

        string saveDataString = JsonUtility.ToJson(saveData);
        PlayerPrefs.SetString("GameData", saveDataString);
        PlayerPrefs.Save();
    }

    private void LoadGameData()
    {
        if (PlayerPrefs.HasKey("GameData"))
        {
            string saveDataString = PlayerPrefs.GetString("GameData");
            saveData = JsonUtility.FromJson<SaveData>(saveDataString);

            totalScore = saveData.totalScore;
            progres = saveData.progres;
        }
        else
        {
            saveData = new SaveData();
            saveData.totalScore = 0;
            saveData.progres = 1;
        }
    }
    public void ResetGameData()
{
    PlayerPrefs.DeleteAll();

    totalScore = 0;
    progres = 1;

    SaveGameData();
}
}
