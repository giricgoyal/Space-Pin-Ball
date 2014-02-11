using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {
	
	bool en = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		if (Application.loadedLevelName.CompareTo("EndGame") == 0) {
			GUILayout.BeginArea(new Rect(Screen.width/2 - 150, 10, 300,50));
			GUILayout.BeginHorizontal();
				if (GUILayout.Button("Main Menu")) {
					Application.LoadLevel("StartGame");
				}
				if (GUILayout.Button("Credits")) {
					GameObject.Find("EndCredits").transform.position = new Vector3(1.66516f, 15.17334f, -30.81231f);
				}
				if (GUILayout.Button("Quit")) {
					Application.Quit();
				}
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
		
		
		if (Application.loadedLevelName.CompareTo("Level_1") == 0) {
			GUILayout.BeginArea(new Rect(Screen.width/2 - 150, 10, 300,50));
			GUILayout.BeginHorizontal();
				if (GUILayout.Button("Main Menu")) {
					Application.LoadLevel("StartGame");
				}
				if (GUILayout.Button("Quit")) {
					Application.Quit();
				}
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
		
		if (Application.loadedLevelName.CompareTo("Level_2") == 0) {
			GUILayout.BeginArea(new Rect(Screen.width/2 - 150, 10, 300,50));
			GUILayout.BeginHorizontal();
				if (GUILayout.Button("Main Menu")) {
					Application.LoadLevel("StartGame");
				}
				if (GUILayout.Button("Quit")) {
					Application.Quit();
				}
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
		
		if (Application.loadedLevelName.CompareTo("StartGame") == 0) {
			GUILayout.BeginArea(new Rect(Screen.width/2 - 150, 10,300,50));
			GUILayout.BeginHorizontal();
				if (GUILayout.Button("Start Game")) {
					Application.LoadLevel("Level_1");
					ScoreCountScript.reset();
				}
				if (GUILayout.Button("Controls")) {
					GameObject.Find("HowToPlay").GetComponent<Renderer>().renderer.enabled = !en;
					GameObject.Find("t1").GetComponent<Renderer>().renderer.enabled = !en;
					GameObject.Find("t2").GetComponent<Renderer>().renderer.enabled = !en;
					GameObject.Find("t3").GetComponent<Renderer>().renderer.enabled = !en;
					GameObject.Find("t4").GetComponent<Renderer>().renderer.enabled = !en;
					GameObject.Find("t5").GetComponent<Renderer>().renderer.enabled = !en;
					GameObject.Find("t6").GetComponent<Renderer>().renderer.enabled = !en;
					GameObject.Find("t7").GetComponent<Renderer>().renderer.enabled = !en;	
					GameObject.Find("t8").GetComponent<Renderer>().renderer.enabled = !en;
					GameObject.Find("t9").GetComponent<Renderer>().renderer.enabled = !en;
					en = !en;
				}
				if (GUILayout.Button("Quit")) {
					Application.Quit();
				}
			GUILayout.EndVertical();
			GUILayout.EndArea();
		}
	}
}
