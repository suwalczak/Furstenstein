﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Points : MonoBehaviour {
    public static int score;
    Text goldText;    

	// Use this for initialization
	void Start () {
        goldText = GetComponent<Text>();
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		goldText.text = "" + score;
	}



}
