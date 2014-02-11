using UnityEngine;
using System.Collections;

public class recollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter() {
		Collider ball = GameObject.Find("PinBall").GetComponent<Collider>();
		ball.collider.isTrigger = false;
	}
}
