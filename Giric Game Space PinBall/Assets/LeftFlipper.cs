using UnityEngine;
using System.Collections;

public class LeftFlipper : MonoBehaviour {

	int speed;
	// Use this for initialization
	void Start () {
		speed = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
		// Level 1
		if (Application.loadedLevelName.CompareTo("Level_1") == 0) {
			if (Input.GetKeyDown(KeyCode.LeftArrow)) {
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,150,0), Time.time*speed); 
				//collider.enabled = false;
				audio.Play();
			}
			if (Input.GetKeyUp(KeyCode.LeftArrow)) {
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,190,0), Time.time*speed);
				
			}
			
		}
		
		// Level 2
		else {
			if (Input.GetKeyDown(KeyCode.LeftArrow)) {
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,150,0), Time.time*speed); 
				//collider.enabled = false;
				
			}
			if (Input.GetKeyUp(KeyCode.LeftArrow)) {
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,190,0), Time.time*speed);
				
			}
		}
	}
	
	void OnCollisionExit(Collision collision) {
		if (collision.gameObject.Equals(GameObject.Find("PinBall"))) {
			//GameObject.Find("PinBall").GetComponent<Collider>().collider.isTrigger = true;
		}
	}
	
}
