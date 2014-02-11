using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {
	
	public static bool endGame;
	// Use this for initialization
	void Start () {
		endGame = false;
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (Application.loadedLevelName.CompareTo("Level_2") == 0 && !endGame) {
			if (ScoreCountScript.scoreCount < 0) {
				if (LivesCountScript.livesCount <= 0){
					Application.LoadLevel("EndGame");
					endGame = true;
				}
				else {
					Application.LoadLevel("Level_1");
					LivesCountScript.livesCount -= 1;
				}		
			}
		}
		
		
		if (LivesCountScript.livesCount < 0 && !endGame) {
			Application.LoadLevel("EndGame");
			endGame = true;
		}
		
		
		if (BossScript.bossHealth < 0 && !endGame) {
			endGame = true;
			Application.LoadLevel("EndGame");
		}
		
		*/
		if (Application.loadedLevelName.CompareTo("EndGame") == 0) {
			if (BossScript.bossHealth < 0) {
				GameObject.Find("YouWon").GetComponent<TextMesh>().text = "You Win!";
			}
			else {	
				GameObject.Find("YouLose").GetComponent<TextMesh>().text = "You Lose!";
			}
			GameObject.Find("Score").GetComponent<TextMesh>().text = ScoreCountScript.scoreCount.ToString();
			GameObject.Find("EndCredits").rigidbody.velocity = new Vector3(0, 0, 1f);
			
		}
		
		/*
		else if (Application.loadedLevelName.CompareTo("StartGame") == 0) {
			if (Time.time > 5) {
				Application.LoadLevel("Level_1");
			}
		}
		*/
	}
	
	public static void end() {
		if (Application.loadedLevelName.CompareTo("Level_2") == 0 && !endGame) {
			if (ScoreCountScript.scoreCount < 0) {
				if (LivesCountScript.livesCount <= 0){
					
					Application.LoadLevel("EndGame");
					
					endGame = true;
				}
				else {
					Application.LoadLevel("Level_1");
					LivesCountScript.livesCount -= 1;
				}		
			}
		}
		
		
		if (LivesCountScript.livesCount < 0 && !endGame) {
			
			Application.LoadLevel("EndGame");
			
			endGame = true;
		}
		
		
		if (BossScript.bossHealth < 0 && !endGame) {
			endGame = true;
			
			Application.LoadLevel("EndGame");
			
		}
	}	
}
