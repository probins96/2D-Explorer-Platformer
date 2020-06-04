﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
#if UNITY_EDITOR
using UnityEditor;
#endif 

public class HealthBarScript : MonoBehaviour {

	Image healthBar;
	public static float maxHealth = 100f;
	public static float health = 100f;
	public static bool resetGame;

	// Use this for initialization
	void Start () {
		healthBar = GetComponent<Image>();
	}

	// Update is called once per frame
	void Update () {

		healthBar.fillAmount = health / maxHealth;

		if(health == 0){

			// character dies

				FindObjectOfType<AudioManager>().Play("PlayerDeath");

				// resetting stuff
			  health = 100f;
				BoatScript.lastPosition.x = 21.655f;
				BoatScript.lastPosition.y =-122.8813f;
				HUD.hasCompletedPuzzle = false;
				CharacterMovement.showCoin = false;
				HUD.hasCompletedPuzzle = false;
				
				#if UNITY_EDITOR
				EditorUtility.DisplayDialog("YOU DIED!", "TRY AGAIN","GO TO MAIN MENU");
				#endif 
				SceneManager.LoadScene("MainMenu");
	
		}	
	}
}
