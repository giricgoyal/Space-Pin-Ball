using UnityEngine;
using System.Collections;

public class spring : MonoBehaviour {
	
	public static float elapsedTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		// Level 1
		if (Application.loadedLevelName.CompareTo("Level_1") == 0) {
			elapsedTime = Time.time - Launch.sttime;
			if (Launch.launchFlag == 1) {
				if (Input.GetKey(KeyCode.Space)) {
					if (elapsedTime < 4) {
						transform.localScale -= new Vector3(0,0,0.009f);
					}
				}
				if (Input.GetKeyUp(KeyCode.Space)) {
					transform.localScale = new Vector3(1,1,2);
				}
			}
		}
		
		// Level 2
		else {
		}
	}
}
