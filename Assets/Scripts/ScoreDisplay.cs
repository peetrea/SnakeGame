using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
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

    public void UpdateScoreText()
    {
        scoreText.text = GlobalManager.Instance.score.ToString();
    }
}

