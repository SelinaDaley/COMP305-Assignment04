using UnityEngine;
using System.Collections;

public class CubeController_Level2 : MonoBehaviour {

	public GameController gameController;
	//public GameObject[] blockades;
	//public GameObject blackTarget;
	//public AudioSource sound;
	
	private int totalTargets;

	// Use this for initialization
	void Start () 
	{
		totalTargets = 8;
		//gameController.targetsRemaining = totalTargets;		
		gameController.helpLabel.text = "Collect the cubes\nCubes Remaining " + gameController.targetsRemaining + "/" + totalTargets;
	}
	
	// Update is called once per frame
	void Update () {
		//gameController.targetsRemaining = totalTargets;		
		gameController.helpLabel.text = "Collect the cubes\nCubes Remaining " + gameController.targetsRemaining + "/" + totalTargets;

	}
}
