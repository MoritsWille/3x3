using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CountDown : MonoBehaviour {
    public float TimeLeft = 4f;
    string TextString;
    Text Text;

    // Use this for initialization
    void Start () {
        Text = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        TimeLeft -= Time.deltaTime;
        if (TimeLeft <= 0.5f)
        {
            Application.LoadLevel("Game");
        }
        TextString = TimeLeft.ToString();
        Text.text = TextString;
	}
}
