using UnityEngine;
using System.Collections;
using System.IO;
using GooglePlayGames;

public class MenuControl : MonoBehaviour {
    public int Score;
    public int HighScore;
    string Path1 = Application.persistentDataPath + @"\score.txt";
    string Path2 = Application.persistentDataPath + @"\highscore.txt";
    string Path3 = Application.persistentDataPath + @"\orangebox.txt";
    string Path4 = Application.persistentDataPath + @"\greenbox.txt";
    //string Path1 = Directory.GetCurrentDirectory() + @"\Score.txt";
    //string Path2 = Directory.GetCurrentDirectory() + @"\HighScore.txt";
    //string Path3 = Directory.GetCurrentDirectory() + @"\OrangeBox.txt";
    //string Path4 = Directory.GetCurrentDirectory() + @"\GreenBox.txt";

    // Use this for initialization
    void Start() {
        PlayGamesPlatform.Activate();

        Social.localUser.Authenticate((bool success) => {
            // handle success or failure
        });

		if (!File.Exists(Path1))
		{
			File.Create(Path1);
		}
		if (!File.Exists(Path2))
		{
			File.Create(Path2);
		}
		if (!File.Exists(Path3))
		{
			File.Create(Path3);
		}
		if (!File.Exists(Path4))
		{
			File.Create(Path4);
		}

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
