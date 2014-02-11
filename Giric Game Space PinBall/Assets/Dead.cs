using UnityEngine;
using System.Collections;

public class Dead : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.Equals(GameObject.Find("PinBall"))) {
			
			if (Application.loadedLevelName.CompareTo("Level_1") == 0) {
				audio.Play();
				GameObject ball = GameObject.Find ("PinBall");
				GameObject trigger = GameObject.Find("LaunchObjectTrigger");
				ball.collider.isTrigger = false;
				ball.transform.position = trigger.transform.position;
				Launch.launchFlag = 0;
				LivesCountScript.livesCount -= 1;
				ScoreCountScript.updateScore(-5);
				
			}
			else if (Application.loadedLevelName.CompareTo("Level_2") == 0) {
				GameObject ball = GameObject.Find ("PinBall");
				GameObject trigger = GameObject.Find("LaunchObjectTrigger");
				ball.collider.isTrigger = false;
				Launch.launchFlag = 0;
				
				LivesCountScript.livesCount -= 1;
				ScoreCountScript.updateScore(-5);
				
				Application.LoadLevel("Level_1");
				audio.Play();
			}
			Game.end();
		}

	}
}
