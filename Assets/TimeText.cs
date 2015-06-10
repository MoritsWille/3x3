using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeText : MonoBehaviour {

    public GameObject gm;
    Text TxtObj;

    // Height divided by 16 is font size
    // Use this for initialization
    void Start()
    {
        TxtObj = GetComponent<Text>();
    //    TxtObj.fontSize = Screen.height / 16;
        transform.position = new Vector3(transform.position.x, Screen.height * 0.85f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        Master MasterScript = (Master)gm.GetComponent(typeof(Master));
        int TimeLeft = System.Convert.ToInt32(MasterScript.TimeLeft);
        TxtObj.text =  "Time: " + TimeLeft.ToString();
    }
}
