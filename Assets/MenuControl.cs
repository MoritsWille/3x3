using UnityEngine;
using System.Collections;
using System.IO;

public class MenuControl : MonoBehaviour {
    public int Score;
    public int HighScore;
    string path1 = System.Environment.CurrentDirectory + @"\Score.txt";
    string path2 = System.Environment.CurrentDirectory + @"\HighScore.txt";

	// Use this for initialization
	void Start () {
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
	
	// Update is called once per frame
	void Update () {
	
	}
}
