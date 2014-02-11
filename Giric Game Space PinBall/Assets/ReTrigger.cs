using UnityEngine;
using System.Collections;

public class ReTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter() {
		
		// Level 1
		if (Application.loadedLevelName.CompareTo("Level_1") == 0) {
			GameObject ball = GameObject.Find("PinBall");
			ball.collider.isTrigger = false;	
		}
		
		// Level 2
		else {
		
		}
	}
}
