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
		gameController.GameOver ();
		gameController.gameOverLabel.text = "You finished!"; 
		Invoke ("LoadIt", 3);
	}
}
