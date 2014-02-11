using UnityEngine;
using System.Collections;

public class WaitWhat : MonoBehaviour {
	
	public static bool waitWhat = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.Equals(GameObject.Find("PinBall"))) {
			waitWhat = true;
		}
	}
}
