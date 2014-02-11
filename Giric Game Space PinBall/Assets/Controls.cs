using UnityEngine;
using System.Collections;

public class Controls : MonoBehaviour {
	
	
	GameObject flipper, table, ball;
	Vector3 ballPivotDir;
	Vector3 hor;
	float angle;
	Vector3 surfNormal;
	Vector3 strikeDir;
	
	public static string loadLevel;
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void FixedUpdate() {
		
		ball = GameObject.Find("PinBall");
		table = GameObject.Find("TableTop");
		
		
		// Reset Game
		if (Input.GetKeyDown(KeyCode.R)) {
			
			GameObject trigger = GameObject.Find("LaunchObjectTrigger");
			ball.collider.isTrigger = false;
			ball.transform.position = trigger.transform.position;
			//GameObject.Find("PinBall").SetActive(false);
			Application.LoadLevel("Level_1");
			ScoreCountScript.reset();
			LivesCountScript.reset();
		}
		
		// Quit Game
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit();
		}
		
		// Activate Portal
		if (Input.GetKeyDown(KeyCode.P)) {
			Vector3 pos = new Vector3(Random.Range(-1f,6f), 17.12162f, Random.Range(-29f, -27f));
			if (ScoreCountScript.portals > 0 && !ScoreCountScript.startPortal) {
				if (Application.loadedLevelName.CompareTo("Level_1") == 0) {
					loadLevel = "Level_2";
					GameObject portal = Instantiate(GameObject.Find("Portal"), pos, GameObject.Find("Portal").transform.rotation) as GameObject;
					ScoreCountScript.startPortal = true;
				}
				else {
					loadLevel = "Level_1";
					GameObject portal = Instantiate(GameObject.Find("Portal"), pos, GameObject.Find("Portal").transform.rotation) as GameObject;
					ScoreCountScript.startPortal = true;
				}
				ScoreCountScript.portals -= 1;
			}
			
		}
		
		// Activate Extra Damage
		if (Input.GetKeyDown(KeyCode.D)) {
			if (ScoreCountScript.extraDamage > 0 && !ScoreCountScript.startExtraDamage) {
				if (Application.loadedLevelName.CompareTo("Level_2") == 0) {
					ScoreCountScript.startExtraDamage = true;
					ScoreCountScript.startTimeDamage = Time.time;
					ScoreCountScript.extraDamage -= 1;
				}
				
			}
		}
			
		// Right Flipper Impact and Force
		flipper = GameObject.Find("FlipperRight");	
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			if (Vector3.Distance(flipper.transform.position, ball.transform.position) < 4) {
				ballPivotDir = ball.transform.position - flipper.transform.position;
				hor = new Vector3(-1,0,0);
				angle = Vector3.Angle(ballPivotDir, hor);
				if (angle < 40) {
					surfNormal = -table.transform.up;
					strikeDir = Vector3.Cross(ballPivotDir, surfNormal);
					strikeDir.Normalize();
					strikeDir = strikeDir*(33);
					//collider.isTrigger = true;
					ball.rigidbody.AddForce(strikeDir, ForceMode.Impulse);
				}
			}
		}
		
		
		// Left Flipper Impact and Force
		flipper = GameObject.Find("FlipperLeft");
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			if (Vector3.Distance(flipper.transform.position, ball.transform.position) < 4) {
				ballPivotDir = ball.transform.position - flipper.transform.position;
				hor = new Vector3(1,0,0);
				angle = Vector3.Angle(ballPivotDir, hor);
				if (angle < 40) {
					surfNormal = -table.transform.up;
					strikeDir = Vector3.Cross(ballPivotDir, surfNormal);
					strikeDir.Normalize();
					strikeDir = strikeDir*(-33);
					//collider.isTrigger = true;
					ball.rigidbody.AddForce(strikeDir, ForceMode.Impulse);
				}
			}
		}
	}
}
