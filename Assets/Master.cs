﻿using UnityEngine;
using System.Collections;
using System.IO;
using System;
using GooglePlayGames;

public class Master : MonoBehaviour
{
    public int Score = 0;
    public float TimeLeft = 30f;
    public int HighScore;
    public SpriteRenderer Nr1, Nr2, Nr3, Nr4, Nr5, Nr6, Nr7, Nr8, Nr9;
    public Sprite OrangeBox;
    public Sprite BlueBox;
    public Sprite GreenBox;
    public int Orange;
    int Green;
    string ScorePath;
    string HighScorePath;
    string OrangeBoxPath;
    string GreenBoxPath;
	
	// Use this for initialization
    void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            ScorePath = Application.persistentDataPath + @"Score.txt";
            HighScorePath = Application.persistentDataPath + @"HighScore.txt";
            OrangeBoxPath = Application.persistentDataPath + @"OrangeBox.txt";
            GreenBoxPath = Application.persistentDataPath + @"GreenBox.txt";
        }
        else
        {
            ScorePath = Directory.GetCurrentDirectory() + @"\Score.txt";
            HighScorePath = Directory.GetCurrentDirectory() + @"\HighScore.txt";
            OrangeBoxPath = Directory.GetCurrentDirectory() + @"\OrangeBox.txt";
            GreenBoxPath = Directory.GetCurrentDirectory() + @"\GreenBox.txt";
        }

        Orange = Convert.ToInt16(File.ReadAllText(OrangeBoxPath));
        Green = Convert.ToInt16(File.ReadAllText(GreenBoxPath));

        if (Orange == 1) Nr1.sprite = OrangeBox;
        if (Orange == 2) Nr2.sprite = OrangeBox;
        if (Orange == 3) Nr3.sprite = OrangeBox;
        if (Orange == 4) Nr4.sprite = OrangeBox;
        if (Orange == 5) Nr5.sprite = OrangeBox;
        if (Orange == 6) Nr6.sprite = OrangeBox;
        if (Orange == 7) Nr7.sprite = OrangeBox;
        if (Orange == 8) Nr8.sprite = OrangeBox;
        if (Orange == 9) Nr9.sprite = OrangeBox;

        if (Green == 1) Nr1.sprite = GreenBox;
        if (Green == 2) Nr2.sprite = GreenBox;
        if (Green == 3) Nr3.sprite = GreenBox;
        if (Green == 4) Nr4.sprite = GreenBox;
        if (Green == 5) Nr5.sprite = GreenBox;
        if (Green == 6) Nr6.sprite = GreenBox;
        if (Green == 7) Nr7.sprite = GreenBox;
        if (Green == 8) Nr8.sprite = GreenBox;
        if (Green == 9) Nr9.sprite = GreenBox;
    }

    public void FindRandom()
    {
        Nr1.sprite = BlueBox;
        Nr2.sprite = BlueBox;
        Nr3.sprite = BlueBox;
        Nr4.sprite = BlueBox;
        Nr5.sprite = BlueBox;
        Nr6.sprite = BlueBox;
        Nr7.sprite = BlueBox;
        Nr8.sprite = BlueBox;
        Nr9.sprite = BlueBox;

        Orange = Green;
        Green = UnityEngine.Random.Range(1, 10);
        if (Green == Orange) FindRandom();

        if (Orange == 1) Nr1.sprite = OrangeBox;
        if (Orange == 2) Nr2.sprite = OrangeBox;
        if (Orange == 3) Nr3.sprite = OrangeBox;
        if (Orange == 4) Nr4.sprite = OrangeBox;
        if (Orange == 5) Nr5.sprite = OrangeBox;
        if (Orange == 6) Nr6.sprite = OrangeBox;
        if (Orange == 7) Nr7.sprite = OrangeBox;
        if (Orange == 8) Nr8.sprite = OrangeBox;
        if (Orange == 9) Nr9.sprite = OrangeBox;

        if (Green == 1) Nr1.sprite = GreenBox;
        if (Green == 2) Nr2.sprite = GreenBox;
        if (Green == 3) Nr3.sprite = GreenBox;
        if (Green == 4) Nr4.sprite = GreenBox;
        if (Green == 5) Nr5.sprite = GreenBox;
        if (Green == 6) Nr6.sprite = GreenBox;
        if (Green == 7) Nr7.sprite = GreenBox;
        if (Green == 8) Nr8.sprite = GreenBox;
        if (Green == 9) Nr9.sprite = GreenBox;
    }

    // Update is called once per frame
    void Update()
    {
        TimeLeft -= Time.deltaTime;
        if (TimeLeft < 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {

        Social.ReportScore(Score, "CgkIy_2dy-UJEAIQBw", (bool success) =>
        {
            // handle success or failure
        });

        if (Score > 25)
        {
            Social.ReportProgress("CgkIy_2dy-UJEAIQAQ", 100.0f, (bool success) =>
            {
                // handle success or failure
            });
        }
        if (Score > 50)
        {
            Social.ReportProgress("CgkIy_2dy-UJEAIQAg", 100.0f, (bool success) =>
            {
                // handle success or failure
            });
        }
        if (Score > 75)
        {
            Social.ReportProgress("CgkIy_2dy-UJEAIQAw", 100.0f, (bool success) =>
            {
                // handle success or failure
            });
        }
        if (Score > 100)
        {
            Social.ReportProgress("CgkIy_2dy-UJEAIQBA", 100.0f, (bool success) =>
            {
                // handle success or failure
            });
        }
        if (Score > 150)
        {
            Social.ReportProgress("CgkIy_2dy-UJEAIQBQ", 100.0f, (bool success) =>
            {
                // handle success or failure
            });
        }

        Int32.TryParse(File.ReadAllText(HighScorePath), out HighScore);

		if (HighScore < Score)
        {
            File.WriteAllText(HighScorePath, Score.ToString());
            File.WriteAllText(ScorePath, Score.ToString());
        }
        else
        {
            File.WriteAllText(ScorePath, Score.ToString());
        }

        Application.LoadLevel("GameOver");
    }

}