using UnityEngine;
using TMPro;
using System;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private TMP_Text finalScoreText;

    void Start()
    {
        Debug.Log(ScoreManager.FinalScore);
        finalScoreText.text = "Final Score: " + ScoreManager.FinalScore;
    }
}
