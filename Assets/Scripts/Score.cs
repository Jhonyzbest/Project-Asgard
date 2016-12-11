using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
	private int score = 0;
	private int multiplier = 10;
	private GUIText scoreText;

	// Use this for initialization
	void Start () {
		scoreText = GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score;
	}

	public void UpdateScore() {
		score += multiplier;
	}
}
