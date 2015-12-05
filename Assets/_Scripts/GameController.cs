/* Author: Selina Daley */
/* File: GameController.cs */
/* Creation Date: November 20, 2015 */
/* Description: This script controls the text, life, score, and restart values*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public Text scoreLabel;
	public Text lifeLabel;
	public Text timeLabel;
	public Text restartLabel;
	public Text gameOverLabel;
	public Text helpLabel;
	
	public int targetsRemaining;
	public int targetsKilled;
	public int lifeValue;
	public bool gameOver;	
	public float totalTime;

	public GameObject player;

	// PRIVATE INSTANCE VARIABLES
	private bool _restart;
	private int _scoreValue;
	private float _timeValue;
	private float _timeRemaining;

	// Use this for initialization
	void Start () {
		timeLabel.text = "Time: " + totalTime;
		restartLabel.text = "";
		gameOverLabel.text = "";

		gameOver = false;
		_restart = false;
		_scoreValue = 0;
		_timeValue = 0;

		UpdateScore ();
		UpdateLife ();
	}
	
	// Update is called once per frame
	void Update () {
		_timeValue = Mathf.RoundToInt (Time.timeSinceLevelLoad);
		_timeRemaining = totalTime - _timeValue;

		// Used to check if the player has run out of time
		if(_timeRemaining == 0)
		{
			timeLabel.text = "Time: " + _timeRemaining;
			GameOver();
		}

		// Used to check if the game is over
		if (gameOver == false) 
		{
			timeLabel.text = "Time: " + _timeRemaining;
		}

		// Used to check if the player has pressed R to reloaad the game
		if (_restart) {
			if(Input.GetKeyDown(KeyCode.R)) {
				Application.LoadLevel(Application.loadedLevel);
			}
		}

		// Used to let the player know that the game is over
		if(gameOver) 
		{
			restartLabel.text = "Press 'R' to restart the game";
			_restart = true;
		}		
	}


	// PUBLIC PROPERTIES 
	public void ChangeScore(int score) // Used to increase or decrease the score
	{
		_scoreValue += score;
		UpdateScore ();
	}

	public void ChangeLife(int life) // Used to increase or decrease the players life
	{
		lifeValue += life;
		UpdateLife ();
	}

	public void UpdateScore() // Used to update the score text
	{
		scoreLabel.text = "Score: " + _scoreValue;
	}

	public void UpdateLife() // Used to update the life text
	{
		lifeLabel.text = "Life: " + lifeValue + "%";

		if(lifeValue <= 0) // Used to make the game end once the playerès life is zero or under
		{
			GameOver();
		}
	}
	
	public void GameOver() // Used to stop the player from moving and to alert the player that the game is over
	{
		player.GetComponent<CharacterController>().Move( new Vector3 (0,0,0));
		player.GetComponent<CharacterController>().enabled = false;
		gameOverLabel.text = "Game Over!";
		gameOver = true;
	}
}
