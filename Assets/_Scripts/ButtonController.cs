/* Author: Selina Daley */
/* File: ButtonController.cs */
/* Creation Date: November 20, 2015 */
/* Description: This script creates the button on the start screen */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLES
	float _startTime;
	float _currentTime;
	
	void Start () {
		_startTime = Time.time;
	}

	void Update () 
	{
		_currentTime = Time.time;
	}
	
	void OnGUI() 
	{
		if (_startTime + 2.9f < _currentTime) //Show the button after 2.9 seconds
		{
			if (GUI.Button (new Rect ((Screen.width / 2) - 50, (Screen.height / 2), 100, 30), "Start Game")) {
				Invoke ("LoadIt", 0.50f);
			}
			if (GUI.Button (new Rect ((Screen.width / 2) - 50, (Screen.height / 2) + 50, 100, 30), "Instructions")) {
				Invoke ("LoadIt2", 0.50f);
			}
		}
	}

	//Method to load scene 1
	public void LoadIt()
	{
		Application.LoadLevel(1);
	}
	//Method to load scene 4
	public void LoadIt2()
	{
		Application.LoadLevel(4);
	}

}
