using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	bool gameOver;

	// Use this for initialization
	void Awake(){
		DontDestroyOnLoad (this.gameObject);

		if (instance == null) {
			instance = this;
		} else {
			Destroy (this.gameObject);
		}

	}

	void Start () {
		gameOver = true;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GameStart(){
		GameObject.Find ("PipeSpawner").GetComponent<PipeSpawner> ().StartSpawningPipes ();
		UIManager.instance.GameStart ();
	}

	public void GameOver(){
		gameOver = false;
		GameObject.Find ("PipeSpawner").GetComponent<PipeSpawner> ().StopSpawningPipes ();
		ScoreManager.instance.StopScore ();
		UIManager.instance.GameOver ();
	}

}
