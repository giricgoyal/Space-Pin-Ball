using UnityEngine;
using System.Collections;

public class ScoreCountScript : MonoBehaviour {

	public static int scoreCount = 0;
	public static bool multiplier = false;
	public static int extraDamage = 0;
	public static bool startExtraDamage = false;
	public static float startTimeDamage = 0;
	public static int portals = 0;
	public static bool startPortal = false;
	public static float startTimePortal = 0;
	public static bool portalActive = false;
	public static int countdown = 10;
	public static float startTime = 0;
	
	public static void reset() {
		scoreCount = 0;
		multiplier = false;
		extraDamage = 0;
		startExtraDamage = false;
		startTimeDamage = 0;
		portals = 0;
		startPortal = false;
		startTimePortal = 0;
		portalActive = false;
		countdown = 10;
		startTime = 0;
		LivesCountScript.livesCount = 2;
		BossScript.bossHealth = BossScript.bossMaxHealth + 100;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	
	// Update is called once per frame
	void Update () {
		
		int time;
		if (multiplier) {
			if (Time.time - startTime <= 10) {
				time = (10 - (int)(Time.time - startTime));
				GameObject.Find ("TimerMultiplier").GetComponent<TextMesh>().text = time.ToString() + " sec";
				if (time == 1) 
					GameObject.Find ("TimerMultiplier").GetComponent<TextMesh>().text = "0 sec";
				
			}
			else {
				multiplier = false;
			}
		}
		
		GetComponent<TextMesh>().text =  scoreCount.ToString();
		GameObject.Find("PortalCount").GetComponent<TextMesh>().text = portals.ToString();
		GameObject.Find("MultiplierAvailable").GetComponent<TextMesh>().text = (multiplier?("Yes"):("No"));
		GameObject.Find("ExtraDamageCount").GetComponent<TextMesh>().text = extraDamage.ToString();
	}
	
	
	
	public static void updateScore(int score) {
		
		if (multiplier) {
			scoreCount += score*2;			
		}
		else 
			scoreCount += score;
		Game.end ();
	}
}
