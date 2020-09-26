﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    [Range(0.1f,10f)] [SerializeField] float gameSpeed=1f;
    [SerializeField] int pointsPerBlockDestroyed=83;
    [SerializeField] TextMeshProUGUI scorText;

    [SerializeField] int currentScore = 0;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if (gameStatusCount>1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }

    void Start()
    {
        scorText.text = currentScore.ToString();
    }
    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scorText.text = currentScore.ToString();
    }

    void Update()
    {
        Time.timeScale = gameSpeed;

    }
}
