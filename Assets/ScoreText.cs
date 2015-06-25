using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreText : MonoBehaviour {
    Text ScoreTextText;
    public GameObject gm;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        MenuControl gmScript = (MenuControl)gm.GetComponent(typeof(MenuControl));
        ScoreTextText = GetComponent<Text>();
        if (gmScript.HighScore == gmScript.Score)
        {
            ScoreTextText.text = "   New high score! " + gmScript.HighScore.ToString();
        }
        else ScoreTextText.text = "Score: " + gmScript.Score.ToString() + " High Score: " + gmScript.HighScore.ToString();
	}
}
