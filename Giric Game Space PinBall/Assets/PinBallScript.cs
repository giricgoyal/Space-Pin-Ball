using UnityEngine;
using System.Collections;

public class PinBallScript : MonoBehaviour {
	
	GameObject flipper, table;
	Vector3 ballPivotDir;
	Vector3 hor;
	float angle;
	Vector3 surfNormal;
	Vector3 strikeDir;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (rigidbody.position.x < -3.1) {
			//rigidbody.velocity = -rigidbody.velocity;
			rigidbody.position = new Vector3(-2, rigidbody.position.y, rigidbody.position.z);
			
		}
		if (rigidbody.position.z > -11.3) {
			//rigidbody.velocity = -rigidbody.velocity;
			rigidbody.position = new Vector3(rigidbody.position.x, rigidbody.position.y, -13);
		}
		/*
		if (rigidbody.velocity.z < -40) {
			print (rigidbody.velocity.ToString ());
			rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y, -40f);
			print (rigidbody.velocity.ToString ());
		}
		
		if (rigidbody.velocity.z > 40 && (WaitWhat.waitWhat || (Application.loadedLevelName.CompareTo("Level_2") == 0))) {
			print (rigidbody.velocity.ToString ());
			rigidbody.velocity = new Vector3(rigidbody.velocity.x, rigidbody.velocity.y, 40f);
			print (rigidbody.velocity.ToString ());
		}
		
		if (rigidbody.velocity.x < -40) {
			print (rigidbody.velocity.ToString ());
			rigidbody.velocity = new Vector3(-40f, rigidbody.velocity.y, rigidbody.velocity.z);
			print (rigidbody.velocity.ToString ());
		}
		*/
	}
	
	void OnCollisionEnter(Collision collision) {
		audio.Play();
		if (collision.gameObject.Equals(GameObject.Find("PinBall"))) {
		// level 1
		if (Application.loadedLevelName.CompareTo("Level_1") == 0) {
			table = GameObject.Find("TableTop");
			
			// Right Flipper Impact and Force
			flipper = GameObject.Find("FlipperRight");	
			if (Input.GetKeyDown(KeyCode.RightArrow)) {
				if (Vector3.Distance(flipper.transform.position, transform.position) < 2) {
					ballPivotDir = transform.position - flipper.transform.position;
					hor = new Vector3(-1,0,0);
					angle = Vector3.Angle(ballPivotDir, hor);
					if (angle < 40) {
						surfNormal = -table.transform.up;
						strikeDir = Vector3.Cross(ballPivotDir, surfNormal);
						strikeDir.Normalize();
						strikeDir = strikeDir*(250);
						//collider.isTrigger = true;
						rigidbody.AddForce(strikeDir, ForceMode.Impulse);
					}
				}
				else {
				
				}
			}
			
			
			// Left Flipper Impact and Force
			flipper = GameObject.Find("FlipperLeft");
			if (Input.GetKeyDown(KeyCode.LeftArrow)) {
				if (Vector3.Distance(flipper.transform.position, transform.position) < 2) {
					ballPivotDir = transform.position - flipper.transform.position;
					hor = new Vector3(1,0,0);
					angle = Vector3.Angle(ballPivotDir, hor);
					if (angle < 40) {
						surfNormal = -table.transform.up;
						strikeDir = Vector3.Cross(ballPivotDir, surfNormal);
						strikeDir.Normalize();
						strikeDir = strikeDir*(-250);
						//collider.isTrigger = true;
						rigidbody.AddForce(strikeDir, ForceMode.Impulse);
					}
				}
				else {
				
				}
			}
		}
		
		// Level 2
		else {
			table = GameObject.Find("TableTop");
			
			// Right Flipper Impact and Force
			flipper = GameObject.Find("FlipperRight");	
			if (Input.GetKeyDown(KeyCode.RightArrow)) {
				if (Vector3.Distance(flipper.transform.position, transform.position) < 2) {
					ballPivotDir = transform.position - flipper.transform.position;
					hor = new Vector3(-1,0,0);
					angle = Vector3.Angle(ballPivotDir, hor);
					if (angle < 40) {
						surfNormal = -table.transform.up;
						strikeDir = Vector3.Cross(ballPivotDir, surfNormal);
						strikeDir.Normalize();
						strikeDir = strikeDir*(250);
						//collider.isTrigger = true;
						rigidbody.AddForce(strikeDir, ForceMode.Impulse);
					}
				}
			}
			
			
			// Left Flipper Impact and Force
			flipper = GameObject.Find("FlipperLeft");
			if (Input.GetKeyDown(KeyCode.LeftArrow)) {
				if (Vector3.Distance(flipper.transform.position, transform.position) < 2) {
					ballPivotDir = transform.position - flipper.transform.position;
					hor = new Vector3(1,0,0);
					angle = Vector3.Angle(ballPivotDir, hor);
					if (angle < 40) {
						surfNormal = -table.transform.up;
						strikeDir = Vector3.Cross(ballPivotDir, surfNormal);
						strikeDir.Normalize();
						strikeDir = strikeDir*(-250);
						//collider.isTrigger = true;
						rigidbody.AddForce(strikeDir, ForceMode.Impulse);
					}
				}
			}
		}
		}
	}
	/*
	void OnCollisionEnter(Collision collision) {
		//print(collision.gameObject.ToString());
		audio.Play();
	}*/
}
