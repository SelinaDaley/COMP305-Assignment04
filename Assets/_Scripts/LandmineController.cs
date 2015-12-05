/* Author: Selina Daley */
/* File: LandmineController.cs */
/* Creation Date: November 20, 2015 */
/* Description: This script controls the landmine game objects */

using UnityEngine;
using System.Collections;

public class LandmineController : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public GameObject explosion;
	public GameController gameController;

	// PRIVATE INSTANCE VARIABLES
	private float startTime;
	private float currentTime;

	// Use this for initialization
	void Start () {
		startTime  = Time.time;
	}
	
	// Update is called once per frame
	void Update () 
	{
		currentTime  = Time.time;

		// Three seconds after this object is made set kinematic to true to stop the gameobject from
		// moving and set is trigger to true so the player can interact with it
		// If kinematic stays false and trigger is set to true the object will fall through the level
		if(currentTime > startTime + 3)
		{
			this.GetComponent<Rigidbody>().isKinematic = true;
			this.GetComponent<BoxCollider>().isTrigger = true;
		}
	}

	// When the player collides with this object take 20% life away from the player
	void OnTriggerEnter (Collider other)
	{
		if(other.CompareTag("Player"))
		{
			Destroy (this.gameObject);
			Instantiate(this.explosion, this.transform.position, Quaternion.identity);
			gameController.ChangeLife(-20);
		}
	}
}
