using UnityEngine;
using System.Collections;

public class WarnHoleScript : MonoBehaviour {

	int count = 2;
	int variable = 0;
	float rotation = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		rotation += 0.1f;
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
				display.GetComponent<TextMesh>().text = "Entering Warm Hole!!";
				yield return new WaitForSeconds(1);
				count--;
			}
			
			display.GetComponent<TextMesh>().text = "";
			//variable = 0;
			
			
			if (count == 0) {
				// get bonus from bonus script
				string bonusGift = BonusScript.getBonus();
				if (bonusGift.Contains("5")) {
					display.GetComponent<TextMesh>().text = "+ " + bonusGift + " Health Points";
					int temp = 0;
					if (bonusGift.Contains ("15"))
						temp = 15;
					if (bonusGift.Contains ("25"))
						temp = 25;
					if (bonusGift.Contains ("35"))
						temp = 35;
					if (bonusGift.Contains ("45"))
						temp = 45;
					ScoreCountScript.scoreCount += temp;
				}
				else if (bonusGift.Contains("+")) {
					display.GetComponent<TextMesh>().text = "+1 Life";
					LivesCountScript.livesCount += 1;
				}
				else if (bonusGift.Contains("x")) {
					display.GetComponent<TextMesh>().text = "x2 Multiplier";
					ScoreCountScript.multiplier = true;
					ScoreCountScript.startTime = Time.time;
					//ScoreCountScript.Wait();
				}
				else if (bonusGift.Contains("portal")) {
					display.GetComponent<TextMesh>().text = "Found Portal";
					ScoreCountScript.portals += 1;
				}
				else if (bonusGift.Contains("Damage")) {
					display.GetComponent<TextMesh>().text = "Found Extra Damage";
					ScoreCountScript.extraDamage += 1;
				}
				variable = 0;
				ball.GetComponent<Light>().intensity = 1;
				ball.GetComponent<Renderer>().renderer.enabled = true;
				ball.rigidbody.velocity = new Vector3((0.5f-Random.value)*20,  0, (0.5f-Random.value)*30);
				yield return new WaitForSeconds(1);
				display.GetComponent<TextMesh>().text = "";
			}
		}
		
	}
	
}
