using UnityEngine;
using System.Collections;

public class LivesScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		// Level 1
		if (Application.loadedLevelName.CompareTo("Level_1") == 0) {
			int lives = LivesCountScript.livesCount;
			if (lives == 0) {
			}
		}
		
		// Level 2
		else {
		
		}
	}
}
