using UnityEngine;
using System.Collections;
using System.IO;
using GooglePlayGames;

public class MenuControl : MonoBehaviour {
    public int Score;
    public int HighScore;
    string path1 = Application.persistentDataPath + @"\Score.txt";
    string path2 = Application.persistentDataPath + @"\HighScore.txt";

    // Use this for initialization
    void Start() {
        PlayGamesPlatform.Activate();

        Social.localUser.Authenticate((bool success) => {
            // handle success or failure
        });

        if (!File.Exists(path1))
        {
            File.Create(path1);
        }
        if (!File.Exists(path2))
        {
            File.Create(path2);
        }

        using (StreamReader sr = new StreamReader(path2))
        {
            HighScore = int.Parse(sr.ReadLine());
        }

        using (StreamReader sr = new StreamReader(path1))
        {
            Score = int.Parse(sr.ReadLine());
        }
	}

    public void Quit()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        Application.LoadLevel("Game");
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
