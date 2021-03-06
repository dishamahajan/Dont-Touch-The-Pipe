﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager instance;
	public int score;
	// Use this for initialization

	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}
	void Start () {
		score=0;
		PlayerPrefs.SetInt ("Score", 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void IncrementScore(){
		score++;
	}

	public void StopScore(){
		PlayerPrefs.SetInt ("Score", score);
		if (PlayerPrefs.HasKey ("HighScore")) {
			if (score > PlayerPrefs.GetInt ("HighScore")) {
				PlayerPrefs.SetInt ("HighScore", score);
			}
		} else {
			PlayerPrefs.SetInt ("HighScore", score);
		}
	}
}
