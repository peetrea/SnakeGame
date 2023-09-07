using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalManager : MonoBehaviour
{
    public static GlobalManager Instance { get; private set; }
    public int score;
    public int curentLevel;
    private ScoreDisplay scoreDisplay;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        scoreDisplay = FindObjectOfType<ScoreDisplay>();
    }

    private void Update()
    {
        Debug.Log(score);
    }
}