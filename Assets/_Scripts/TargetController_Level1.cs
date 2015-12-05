using UnityEngine;
using System.Collections;

public class TargetController_Level1 : MonoBehaviour {

	public GameController gameController;
	public GameObject[] blockades;
	public GameObject blackTarget;
	public AudioSource sound;

	private int totalTargets;

	// Use this for initialization
	void Start () {

		Instantiate(blackTarget, new Vector3(23.5f, 2.5f, -15.5f), Quaternion.Euler( new Vector3(90f, 0f, 0f))); 
		Instantiate(blackTarget, new Vector3(25.5f, 2.5f, -15.5f), Quaternion.Euler( new Vector3(90f, 0f, 0f)));
		Instantiate(blackTarget, new Vector3(27.5f, 2.5f, -15.5f), Quaternion.Euler( new Vector3(90f, 0f, 0f)));

		totalTargets = 3;
		gameController.targetsRemaining = totalTargets;

		gameController.helpLabel.text = "Shoot the targets\nTargets Remaining " + gameController.targetsRemaining + "/" + totalTargets;
	}
	
	// Update is called once per frame
	void Update () {

		gameController.helpLabel.text = "Shoot the targets\nTargets Remaining " + gameController.targetsRemaining + "/" + totalTargets;


		if(gameController.targetsKilled == 3 && blockades[0] == true)
		{
			Instantiate(blackTarget, new Vector3(23.5f, 2.5f, 8.5f), Quaternion.Euler( new Vector3(90f, 0f, 0f)));
			Instantiate(blackTarget, new Vector3(25.5f, 2.5f, 8.5f), Quaternion.Euler( new Vector3(90f, 0f, 0f)));
			Instantiate(blackTarget, new Vector3(27.5f, 2.5f, 8.5f), Quaternion.Euler( new Vector3(90f, 0f, 0f)));

			Destroy(blockades[0]);
			sound.Play();
			totalTargets = 3;
			gameController.targetsRemaining = totalTargets;
		}

		if(gameController.targetsKilled == 6 && blockades[1] == true)
		{
			Instantiate(blackTarget, new Vector3(22f, 2.5f, 27f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));
			Instantiate(blackTarget, new Vector3(22f, 2.5f, 25f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));
			Instantiate(blackTarget, new Vector3(22f, 2.5f, 23f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));

			Destroy(blockades[1]);
			sound.Play();
			totalTargets = 3;
			gameController.targetsRemaining = totalTargets;
		}

		if(gameController.targetsKilled == 9 && blockades[2] == true)
		{
			Instantiate(blackTarget, new Vector3(-6.5f, 2.5f, 27f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));
			Instantiate(blackTarget, new Vector3(-6.5f, 2.5f, 25f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));
			Instantiate(blackTarget, new Vector3(-6.5f, 2.5f, 23f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));

			Destroy(blockades[2]);
			sound.Play();
			totalTargets = 3;
			gameController.targetsRemaining = totalTargets;
		}

		if(gameController.targetsKilled == 12 && blockades[3] == true)
		{
			Instantiate(blackTarget, new Vector3(-28f, 2.5f, 28.5f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));
			Instantiate(blackTarget, new Vector3(-28f, 4.0f, 26f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));
			Instantiate(blackTarget, new Vector3(-28f, 2.5f, 23.5f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));
			Instantiate(blackTarget, new Vector3(-28f, 4.0f, 21f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));
			Instantiate(blackTarget, new Vector3(-28f, 2.5f, 18.5f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));
			Instantiate(blackTarget, new Vector3(-28f, 4.0f, 16f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));
			Instantiate(blackTarget, new Vector3(-28f, 2.5f, 13.5f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));

			Destroy(blockades[3]);
			sound.Play();
			totalTargets = 7;
			gameController.targetsRemaining = totalTargets;
		}

		if(gameController.targetsKilled == 19 && blockades[4] == true)
		{
			//Call Create Mass Targets

			Destroy(blockades[4]);
			sound.Play();
			totalTargets = 15;
			gameController.targetsRemaining = totalTargets;
		}

		if(gameController.targetsKilled == 34 && blockades[5] == true)
		{
			Instantiate(blackTarget, new Vector3(17.5f, 2f, -26f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));
			Instantiate(blackTarget, new Vector3(17.5f, 4f, -26f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));
			Instantiate(blackTarget, new Vector3(17.5f, 2f, -28.5f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));
			Instantiate(blackTarget, new Vector3(17.5f, 4f, -28.5f), Quaternion.Euler( new Vector3(90f, 90f, 0f)));

			Destroy(blockades[5]);
			sound.Play();
			totalTargets = 4;
			gameController.targetsRemaining = totalTargets;
		}

		if(gameController.targetsKilled == 38)
		{
			totalTargets = 10;
			gameController.targetsRemaining = totalTargets;
		}

		if(gameController.targetsKilled == 48 && blockades[6] == true)
		{
			Destroy(blockades[6]);
			sound.Play();
			totalTargets = 0;
			gameController.targetsRemaining = totalTargets;
		}

		if(gameController.targetsKilled != 48)
			gameController.helpLabel.text = "Shoot the targets\nTargets Remaining " + gameController.targetsRemaining + "/" + totalTargets;
		else
			gameController.helpLabel.text = "Enter the portal";

	}
}
