using UnityEngine;
using System.Collections;

public class RightFlipper : MonoBehaviour {
	int speed;
	// Use this for initialization
	void Start () {
		speed = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
		// Level 1
		if (Application.loadedLevelName.CompareTo("Level_1") == 0) {
			if (Input.GetKeyDown(KeyCode.RightArrow)) {
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,30,0), Time.time*speed); 
				//collider.enabled = false;
				audio.Play();
			}
			if (Input.GetKeyUp(KeyCode.RightArrow)) {
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,350,0), Time.time*speed);
				
			}
		}
		
		// level 2
		else {
			if (Input.GetKeyDown(KeyCode.RightArrow)) {
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,30,0), Time.time*speed); 
				//collider.enabled = false;
				audio.Play();
			}
			if (Input.GetKeyUp(KeyCode.RightArrow)) {
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,350,0), Time.time*speed);
				
			}
			
		}
	}
	
	void OnCollisionExit(Collision collision) {
		if (collision.gameObject.Equals(GameObject.Find("PinBall"))) {
			//GameObject.Find("PinBall").GetComponent<Collider>().collider.isTrigger = true;
		}
	}
}
