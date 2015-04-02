using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {
    public GameObject gm;
    int Name;

	// Use this for initialization
	void Start () {
        if (gameObject.name == "Box(1,-1)") Name = 1;
        if (gameObject.name == "Box(1,0)") Name = 2;
        if (gameObject.name == "Box(1,1)") Name = 3;
        if (gameObject.name == "Box(0,-1)") Name = 4;
        if (gameObject.name == "Box(0,0)") Name = 5;
        if (gameObject.name == "Box(0,1)") Name = 6;
        if (gameObject.name == "Box(-1,-1)") Name = 7;
        if (gameObject.name == "Box(-1,0)") Name = 8;
        if (gameObject.name == "Box(-1,1)") Name = 9;
	}
	
	void OnMouseDown () {
        Master MasterScript = (Master)gm.GetComponent(typeof(Master));

        if (Name == MasterScript.Orange)
        {
            MasterScript.FindRandom();
            MasterScript.Score++;
        }
        else MasterScript.GameOver();
	}
}
