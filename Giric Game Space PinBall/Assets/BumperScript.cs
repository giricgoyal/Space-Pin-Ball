using UnityEngine;
using System.Collections;

public class BumperScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	IEnumerator OnCollisionEnter(Collision collision) {
		//Collision collison;
		
		// level 1
		if (Application.loadedLevelName.CompareTo("Level_1") == 0) {
			audio.Play();
			GameObject ball = GameObject.Find ("PinBall");
			ball.rigidbody.AddForce(0, 0, 200, ForceMode.Impulse);
			Vector3 dir =  Vector3.Reflect(ball.rigidbody.velocity, collision.contacts[0].normal);
			dir = dir *(1.5f);
			ball.rigidbody.velocity = dir;
			ScoreCountScript.updateScore(10);
			particleSystem.enableEmission = true;
			yield return new WaitForSeconds(1.5f);
			particleSystem.enableEmission = false;
			
		}
		
		// Level 2
		else {
		
		}
		
	}
	
}
