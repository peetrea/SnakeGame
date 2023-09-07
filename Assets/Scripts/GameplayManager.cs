using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    private ScoreDisplay scoreDisplay;
    public GameObject WinPanel;
    public GameObject LosePanel;
    public GameObject PausePanel;
    private bool isGamePaused = false;
    void Start()
    {
        scoreDisplay = FindObjectOfType<ScoreDisplay>();
    }

    void Update()
    {
        scoreDisplay.UpdateScoreText();
        FinishLevel();
        SwitchPause();
    }
    public void FinishLevel()
    {
        if (GlobalManager.Instance.score <= 0)
        {
            GlobalManager.Instance.score = 0;
            PauseGame();
            ShowWinPanel();
        }
    }
    private void ShowWinPanel()
    {
        WinPanel.SetActive(true);
    }
    public void ShowLosePanel()
    {
        LosePanel.SetActive(true);
    }
    public void SwitchPause()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!isGamePaused)
            {
                PauseGame();
                PausePanel.SetActive(true);
            }
            else
            {
                ResumeGame();
            }
        }
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        isGamePaused = true;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        isGamePaused = false;
        PausePanel.SetActive(false);
    }
    public void BackToMenu()
    {
        GlobalManager.Instance.GoToMenu();
        ResumeGame();
    }
}