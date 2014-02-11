using UnityEngine;
using System.Collections;

public class Launch : MonoBehaviour {
	
	public static int launchFlag;
	public static float sttime;
	
	
	// Use this for initialization
	void Start () {
		launchFlag = 0;
		sttime = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void FixedUpdate() {
		
		// Level 1
		if (Application.loadedLevelName.CompareTo("Level_1") == 0) {
			GameObject ball = GameObject.Find("PinBall");
			if (launchFlag == 1) { 
				if (Input.GetKeyDown(KeyCode.Space)) {
					sttime = (float)Time.time;
				}
				if (Input.GetKeyUp(KeyCode.Space)) {
					float now = (float)Time.time;
					float elapsedTime = now - sttime;
					//ball.rigidbody.AddForce(0, 0, 120, ForceMode.Impulse);
					if (elapsedTime < 4) {
						ball.rigidbody.AddForce(0, 0, elapsedTime * 20, ForceMode.Impulse);
					}
					else {
						ball.rigidbody.AddForce(0, 0, 100, ForceMode.Impulse);				
					}
				}
			}
		}
		
		// Level 2
		else {
		
		}
		
		
	
	}
	
	void OnCollisionEnter() {
		WaitWhat.waitWhat = false;
		// level 1
		if (Application.loadedLevelName.CompareTo("Level_1") == 0) {
			launchFlag = 1; 
			GameObject ball = GameObject.Find("PinBall");
		}
		
		// Level 2
		else {
		}
	}
}
