using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

        if (scoreText == null)
        {
            Debug.LogError("TextMeshProUGUI component not found on this object.");
        }
    }

    public void UpdateTotalScoreText()
    {
        scoreText.text = GlobalManager.Instance.totalScore.ToString();
    }
}

