using UnityEngine;
using System.Collections;

public class BlackHoleScript : MonoBehaviour {
	
	int count = 2;
	int variable = 0;
	float rotation = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		rotation += 0.05f;
		transform.rotation = Quaternion.AngleAxis(rotation,Vector3.up);
		
		if (variable == 1) {
			GameObject ball = GameObject.Find("PinBall");
			ball.transform.position = this.transform.position;
		}
		
	}
	
	
	IEnumerator OnTriggerEnter(Collider ball) {
		
		if (ball.gameObject.Equals(GameObject.Find("PinBall"))) {
			audio.Play();
			GameObject display = GameObject.Find("Display");
			count  = 2;
			ball.GetComponent<Light>().intensity = 0;
			ball.GetComponent<Renderer>().renderer.enabled = false;
			while (count > 0) {
				variable = 1;
				display.GetComponent<TextMesh>().text = "Black Hole!! -15 Health Points";
				yield return new WaitForSeconds(1);
				display.GetComponent<TextMesh>().text = "";
				count--;
			}
			
			display.GetComponent<TextMesh>().text = "";
			//variable = 0;
			
			
			if (count == 0) {
				variable = 0;
				ScoreCountScript.updateScore(-15);
				//ScoreCountScript.scoreCount -= 15;
				ball.GetComponent<Light>().intensity = 1;
				ball.GetComponent<Renderer>().renderer.enabled = true;
				ball.rigidbody.velocity = new Vector3((0.5f-Random.value)*30,  0, (0.5f-Random.value)*20);
			}
		}
		
	}
	
}
