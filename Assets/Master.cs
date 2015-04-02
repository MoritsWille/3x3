using UnityEngine;
using System.Collections;
using System;

public class Master : MonoBehaviour {
    public int Score = 0;
    public int Time =  30;
    int StartTime;
    public SpriteRenderer Nr1, Nr2, Nr3, Nr4, Nr5, Nr6, Nr7, Nr8, Nr9;
    public Sprite OrangeBox;
    public Sprite BlueBox;
    public int Orange;
    int OldOrange = 0;
    string Path1 = Environment.CurrentDirectory + @"\Score.txt";
    string Path2 = Environment.CurrentDirectory + @"\HighScore.txt";

	// Use this for initialization
	void Start () {
        StartTime = DateTime.Now.Second;
        FindRandom();
	}
	
    public void FindRandom()
    {
        OldOrange = Orange;

        Nr1.sprite = BlueBox;
        Nr2.sprite = BlueBox;
        Nr3.sprite = BlueBox;
        Nr4.sprite = BlueBox;
        Nr5.sprite = BlueBox;
        Nr6.sprite = BlueBox;
        Nr7.sprite = BlueBox;
        Nr8.sprite = BlueBox;
        Nr9.sprite = BlueBox;

        Orange = UnityEngine.Random.Range(1, 10);

        if (Orange == 1) Nr1.sprite = OrangeBox;
        if (Orange == 2) Nr2.sprite = OrangeBox;
        if (Orange == 3) Nr3.sprite = OrangeBox;
        if (Orange == 4) Nr4.sprite = OrangeBox;
        if (Orange == 5) Nr5.sprite = OrangeBox;
        if (Orange == 6) Nr6.sprite = OrangeBox;
        if (Orange == 7) Nr7.sprite = OrangeBox;
        if (Orange == 8) Nr8.sprite = OrangeBox;
        if (Orange == 9) Nr9.sprite = OrangeBox;
    }

	// Update is called once per frame
	void Update () {
        if (DateTime.Now.Second == StartTime + 1)
        {
            Time = Time - 1;
            StartTime = DateTime.Now.Second;
        }

        if (Time == 0) GameOver();

        if (Orange == OldOrange) FindRandom();
	}

    public void GameOver()
    {
        if (int.Parse(System.IO.File.ReadAllText(System.Environment.CurrentDirectory + @"\HighScore.txt")) <= Score)
        {
            System.IO.File.WriteAllText(Path2, Score.ToString());
            System.IO.File.WriteAllText(Path1, Score.ToString());
        }
        else if (int.Parse(System.IO.File.ReadAllText(System.Environment.CurrentDirectory + @"\HighScore.txt")) > Score)
        {
            System.IO.File.WriteAllText(Path1, Score.ToString());
        }

        Application.LoadLevel("GameOver");
    }

}
