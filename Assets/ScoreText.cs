using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreText : MonoBehaviour {
    Text ScoreTextText;
    public GameObject GOM;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        MenuControl GOMC = (MenuControl)GOM.GetComponent(typeof(MenuControl));
        ScoreTextText = GetComponent<Text>();
        if (GOMC.HighScore == GOMC.Score)
        {
            ScoreTextText.text = "   New high score! " + GOMC.HighScore.ToString();
        }
        else ScoreTextText.text = "Score: " + GOMC.Score.ToString() + " High Score: " + GOMC.HighScore.ToString();
	}
}
