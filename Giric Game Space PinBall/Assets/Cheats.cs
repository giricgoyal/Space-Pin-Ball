using UnityEngine;
using System.Collections;

public class Cheats : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.F2)) {
			Application.LoadLevel("Level_1");
		}
		if (Input.GetKeyDown(KeyCode.F3)) {
			Application.LoadLevel("Level_2");
		}
		if (Input.GetKeyDown(KeyCode.F1)) {
			Application.LoadLevel("StartGame");
		}
		if (Input.GetKeyDown(KeyCode.F4)) {
			Application.LoadLevel("EndGame");
		}
		if (Input.GetKeyDown(KeyCode.F5)) {
			if (Application.loadedLevelName.CompareTo("Level_1") == 0 || Application.loadedLevelName.CompareTo("Level_2") == 0) {
				ScoreCountScript.scoreCount += 200;
			}
		}
		if (Input.GetKeyDown(KeyCode.F6)) {
			if (Application.loadedLevelName.CompareTo("Level_1") == 0 || Application.loadedLevelName.CompareTo("Level_2") == 0) {
				LivesCountScript.livesCount += 1;
			}
		}
		if (Input.GetKeyDown(KeyCode.F7)) {
			if (Application.loadedLevelName.CompareTo("Level_1") == 0 || Application.loadedLevelName.CompareTo("Level_2") == 0) {
				ScoreCountScript.portals += 2;
			}
		}
		if (Input.GetKeyDown(KeyCode.F8)) {
			if (Application.loadedLevelName.CompareTo("Level_1") == 0 || Application.loadedLevelName.CompareTo("Level_2") == 0) {
				ScoreCountScript.extraDamage += 2;
			}
		}
		if (Input.GetKeyDown(KeyCode.F9)) {
			if (Application.loadedLevelName.CompareTo("Level_1") == 0 || Application.loadedLevelName.CompareTo("Level_2") == 0) {
				ScoreCountScript.multiplier = true;
			}
		}
		if (Input.GetKeyDown(KeyCode.F10)) {
			if (Application.loadedLevelName.CompareTo("Level_1") == 0 || Application.loadedLevelName.CompareTo("Level_2") == 0) {
				BossScript.bossHealth = -1;
				Application.LoadLevel("EndGame");
			}
		}
		
		if (Input.GetKeyDown(KeyCode.Q)) {
			GameObject.Find("PinBall").transform.position = new Vector3(-0.7061559f,17.10362f,-19.84616f);
			GameObject.Find("PinBall").rigidbody.AddForce(new Vector3(Random.Range(-10f,10f), Random.Range(-10f,10f), Random.Range(10f,10f)), ForceMode.Impulse);
		}
	}
}
