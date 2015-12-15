using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour 
{
	//Declare
	//public AudioClip collectSound2;

	private GameController gameController;

	// Use this for initialization
	void Start () 
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent<GameController>();
		}
		if (gameController == null) {
			Debug.Log("Cannot find 'GameController' Script");
		}
	}

	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
	
	void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.tag=="Player")
		{
			//AudioSource.PlayClipAtPoint(collectSound2, transform.position);
			gameController.targetsRemaining -= 1;
			Destroy(gameObject); // this destroys the collider as well
		}
	}
}
