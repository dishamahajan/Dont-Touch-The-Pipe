using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	public static UIManager instance;
	public Text scoreText;
	public Text highScoreText;
	public GameObject gameOverPanel;
	public GameObject startUI;
	public GameObject gameOverText;

	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = ScoreManager.instance.score.ToString ();
	}

	public void GameStart(){
		startUI.SetActive (false);
	}

	public void GameOver(){
		gameOverText.SetActive (true);
		gameOverPanel.SetActive (true);
		highScoreText.text = "High Score: "+PlayerPrefs.GetInt ("HighScore");
	}

	public void Replay(){
		SceneManager.LoadScene ("level1");
	}
	public void Menu(){
		SceneManager.LoadScene ("Menu");
	}
}
