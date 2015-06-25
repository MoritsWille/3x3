using UnityEngine;
using System.Collections;
using System.IO;
using System;
using GooglePlayGames;

public class MenuControl : MonoBehaviour {
    public int Score;
    public int HighScore;
    string Path1 = Application.persistentDataPath + @"\Score.txt";
    string Path2 = Application.persistentDataPath + @"\HighScore.txt";
    //string Path1 = Directory.GetCurrentDirectory() + @"\Score.txt";
    //string Path2 = Directory.GetCurrentDirectory() + @"\HighScore.txt";

    // Use this for initialization
    void Start() {
        Score = Convert.ToInt16(File.ReadAllText(Path1));
        HighScore = Convert.ToInt16(File.ReadAllText(Path2));

        PlayGamesPlatform.Activate();

        Social.localUser.Authenticate((bool success) => {
            // handle success or failure
        });

	}

    public void Quit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        Application.LoadLevel("CountDown");
    }

    public void GotoMenu()
    {
        Application.LoadLevel("Menu");
    }

    public void ShowAchievements()
    {
        Social.ShowAchievementsUI();
    }

    public void ShowLeaderboard()
    {
        PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkIy_2dy-UJEAIQBg");
    }
    // Update is called once per frame
    void Update () {
	
	}
}
