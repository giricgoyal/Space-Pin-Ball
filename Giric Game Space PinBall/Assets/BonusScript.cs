using UnityEngine;
using System.Collections;

public class BonusScript : MonoBehaviour {
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public static string getBonus() {
		
		
			string[] bonusGift;
			bonusGift = new string[10];
			bonusGift[0] = "15";
			bonusGift[1] = "25";
			bonusGift[2] = "35";
			bonusGift[3] = "45";
			bonusGift[4] = "25";
			bonusGift[5] = "+1";
			bonusGift[6] = "portal";
			bonusGift[7] = "extraDamage";
			bonusGift[8] = "35";
			bonusGift[9] = "x2";
			
			int choice = Random.Range(0,9);
			return bonusGift[choice];
		}
		
		
}
