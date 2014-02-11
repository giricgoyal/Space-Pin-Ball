using UnityEngine;
using System.Collections;

public class BossScript : MonoBehaviour {
	
	float rotation = 0;
	float translate = 0;
	Vector3 destination;
	bool changeDestination = true;
	
	public static int bossMaxHealth;
	public static int bossHealth;
	int moveSpeed = 1;
	
	
	Transform stuff;
	Vector3 vel;
	float switchDirection = 3;
	float curTime = 0;
	
	bool getDamage = true;
	bool damageTaken = false;
	
	float startTime;
	
	
	// Use this for initialization
	void Start () {
		setVel ();
		if (ScoreCountScript.scoreCount <= 450) 
			bossMaxHealth = bossHealth = ScoreCountScript.scoreCount + 100;
		else 
			bossMaxHealth = bossHealth = 550;
		damageTaken = false;
		
	}
	
	void setVel() {
		if (Random.value > .5) {
			vel.x = 2 * Random.value;
		}
		else {
			vel.x = -2 * Random.value;
		}
		if (Random.value > .5) {
			vel.z = 2 * Random.value;
		}
		else {
			vel.z = -2 * Random.value;
		}
	}
	
	
	// Update is called once per frame
	void Update () {
		
		// move the UFO
		if (curTime < switchDirection) {
			curTime += 1 * Time.deltaTime;
		}
		else {
			setVel();
			if (Random.value > .5) {
				switchDirection += Random.value;
			}
			else {
				switchDirection -= Random.value;
			}
			if (switchDirection < 1) {
				switchDirection = 1 + Random.value;
			}
			curTime = 0;
		
		}
		
		
		
		// rotate the UFO
		rotation += 0.5f;
		transform.rotation = Quaternion.AngleAxis(rotation,Vector3.up);
		
		
		// display boss health
		GameObject.Find("BossHealth").GetComponent<TextMesh>().text = ((float)((float)bossHealth/(float)bossMaxHealth * 100)).ToString();
		
		// timer for extra damage
		int time;
		if (ScoreCountScript.startExtraDamage) {
			if (Time.time - ScoreCountScript.startTimeDamage <= 10) {
				time = (10 - (int)(Time.time - ScoreCountScript.startTimeDamage));
				GameObject.Find ("ExtraDamageTimer").GetComponent<TextMesh>().text = time.ToString() + " sec";
				if (time == 1) 
					GameObject.Find ("ExtraDamageTimer").GetComponent<TextMesh>().text = "0 sec";
					
			}
			else {
				ScoreCountScript.startExtraDamage = false;
			}
		}
		
		
		
		if (transform.position.z < -25) {
			if (getDamage) {
				audio.Play();
				ScoreCountScript.scoreCount -= Random.Range(1,20);
				damageTaken = true;
			}
			getDamage = false;
		}
		else {
			getDamage = true;
		}
		
		
		if (((float)(float)bossHealth/(float)bossMaxHealth*100) <= 50) {
			GameObject.Find("Fire").GetComponent<ParticleSystem>().particleSystem.enableEmission = true;
			GameObject.Find("Fire").GetComponent<ParticleSystem>().particleSystem.emissionRate = (100-(bossHealth/bossMaxHealth*100)) * 10;
		}
	}
	
	
	void FixedUpdate() {
		rigidbody.velocity = vel;
	}
	
	
	IEnumerator OnCollisionEnter(Collision collision) {
		if (collision.gameObject.Equals(GameObject.Find("PinBall"))) {
			GameObject.Find("ufoHit").audio.Play();
			int hit;
			if (ScoreCountScript.startExtraDamage) {
				hit = Random.Range(20,40);
			}
			else {
				hit = Random.Range(10,20);
			}
			bossHealth -= hit;
			particleSystem.enableEmission = true;
			yield return new WaitForSeconds(0.5f);
			particleSystem.enableEmission = false;
			Game.end ();
		}
	}
}
