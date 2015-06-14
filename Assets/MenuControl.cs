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
