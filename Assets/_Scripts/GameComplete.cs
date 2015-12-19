using UnityEngine;
using System.Collections;

public class GameComplete : MonoBehaviour {

	public GameController gameController;
	public GameObject gateLasers;
	
	private int _currentScene;
	
	// Use this for initialization
	void Start () {
		_currentScene = Application.loadedLevel;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameController.targetsRemaining == 0) 
		{
			Destroy(gateLasers);
		}
	}
	
	void LoadIt()
	{
		Application.LoadLevel (_currentScene + 1);
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(_currentScene == 3)
		{
			gameController.GameComplete();
			gameController.gameOverLabel.text = "Game Complete!";
			gameController.restartLabel.text = "Loading main menu...";
			_currentScene = -1;
			Invoke ("LoadIt", 3);
		}
		else
		{
			gameController.GameComplete ();
			Invoke ("LoadIt", 3);
		}
		
	}


}
