using UnityEngine;
using System.Collections;

public class PortalScript : MonoBehaviour {
	
	float rotation = 0; 
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	// Level 1
		if (Application.loadedLevelName.CompareTo("Level_1") == 0) {
			rotation += 0.05f;
			transform.rotation = Quaternion.AngleAxis(rotation,Vector3.up);
		}
		
		// Level 2
		else {
			rotation += 0.05f;
			transform.rotation = Quaternion.AngleAxis(rotation,Vector3.up);
		}
	}
	
	void OnTriggerEnter() {
		audio.Play();
		if (Application.loadedLevelName.CompareTo("Level_1") == 0) {
			if (ScoreCountScript.scoreCount >= 100) {
				Application.LoadLevel("Level_2");
			}
			else {
				GameObject.Find("Display").GetComponent<TextMesh>().text = "You need " + (100 - ScoreCountScript.scoreCount).ToString() + " more Points to advance";
			}
		
		}
		else 
			Application.LoadLevel("Level_1");
		ScoreCountScript.startPortal = false;
	}
	
}
