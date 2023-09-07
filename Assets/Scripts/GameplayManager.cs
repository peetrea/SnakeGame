using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    private ScoreDisplay scoreDisplay;
    public GameObject WinPanel;
    public GameObject LosePanel;
    public GameObject PausePanel;
    void Start()
    {
        scoreDisplay = FindObjectOfType<ScoreDisplay>();
    }

    void Update()
    {
        scoreDisplay.UpdateScoreText();
        FinishLevel();
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
    private void ShowLosePanel()
    {
        LosePanel.SetActive(true);
    }
    private void PauseGame()
    {
        Time.timeScale = 0f;
    }
}
