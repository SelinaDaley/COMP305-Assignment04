using UnityEngine;
using System.Collections;

public class LaserController : MonoBehaviour {

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
	void Update () {
	
	}

	// When the player collides with this object take 20% life away from the player
	void OnTriggerEnter (Collider other)
	{
		if(other.CompareTag("Player"))
		{
			//Destroy (this.gameObject);
			//Instantiate(this.explosion, this.transform.position, Quaternion.identity);
			gameController.ChangeLife(-5);
		}
	}
}
