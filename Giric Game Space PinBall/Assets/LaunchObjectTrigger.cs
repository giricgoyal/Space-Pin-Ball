using UnityEngine;
using System.Collections;

public class LaunchObjectTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter() {
		audio.Play();
		WaitWhat.waitWhat = false;
		//Launch.launchFlag = 0;
	}
}
