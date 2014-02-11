using UnityEngine;
using System.Collections;

public class LivesCountScript : MonoBehaviour {
	
	public static int livesCount = 2;
	
	public static void reset() {
		livesCount = 2;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		// Level 1
		if (Application.loadedLevelName.CompareTo("Level_1") == 0) {
			GetComponent<TextMesh>().text =  livesCount.ToString();
		}
		
		// Level 2
		else {
			
		}
	}
}
