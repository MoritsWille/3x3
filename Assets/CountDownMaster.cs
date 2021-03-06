﻿using UnityEngine;
using System.Collections;
using System;
using System.IO;
using GooglePlayGames;

public class CountDownMaster : MonoBehaviour {
    public SpriteRenderer Nr1, Nr2, Nr3, Nr4, Nr5, Nr6, Nr7, Nr8, Nr9;
    public Sprite OrangeBox;
    public Sprite BlueBox;
    public Sprite GreenBox;
    string OrangeBoxPath;
    string GreenBoxPath;
	public int Orange;
    int Green;
    // Use this for initialization
    void Start () {

        if (Application.platform == RuntimePlatform.Android)
        {
            OrangeBoxPath = Application.persistentDataPath + @"OrangeBox.txt";
            GreenBoxPath = Application.persistentDataPath + @"GreenBox.txt";
        }
        else
        {
            OrangeBoxPath = Directory.GetCurrentDirectory() + @"\OrangeBox.txt";
            GreenBoxPath = Directory.GetCurrentDirectory() + @"\GreenBox.txt";
        }

        Orange = UnityEngine.Random.Range(1, 10);
        Green = UnityEngine.Random.Range(1, 10);
        
        if (Green == Orange)
        {
            Start();
        }
        
        if (Green == 1) Nr1.sprite = GreenBox;
        if (Green == 2) Nr2.sprite = GreenBox;
        if (Green == 3) Nr3.sprite = GreenBox;
        if (Green == 4) Nr4.sprite = GreenBox;
        if (Green == 5) Nr5.sprite = GreenBox;
        if (Green == 6) Nr6.sprite = GreenBox;
        if (Green == 7) Nr7.sprite = GreenBox;
        if (Green == 8) Nr8.sprite = GreenBox;
        if (Green == 9) Nr9.sprite = GreenBox;

        if (Orange == 1) Nr1.sprite = OrangeBox;
        if (Orange == 2) Nr2.sprite = OrangeBox;
        if (Orange == 3) Nr3.sprite = OrangeBox;
        if (Orange == 4) Nr4.sprite = OrangeBox;
        if (Orange == 5) Nr5.sprite = OrangeBox;
        if (Orange == 6) Nr6.sprite = OrangeBox;
        if (Orange == 7) Nr7.sprite = OrangeBox;
        if (Orange == 8) Nr8.sprite = OrangeBox;
        if (Orange == 9) Nr9.sprite = OrangeBox;

        File.WriteAllText(OrangeBoxPath, Orange.ToString());
        File.WriteAllText(GreenBoxPath, Green.ToString());

    }

	// Update is called once per frame
	void Update () {
	}

}
