using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextControl : MonoBehaviour {

    public GameObject gm;
    Text TxtObj;

	// Use this for initialization
	void Start () {
        TxtObj = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        Master MasterScript = (Master)gm.GetComponent(typeof(Master));
        TxtObj.text = "Score: " + MasterScript.Score.ToString();
	}
}