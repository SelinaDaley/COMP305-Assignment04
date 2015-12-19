using UnityEngine;
using System.Collections;

[RequireComponent (typeof (NavMeshAgent))]
public class EnemyAI : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public bool isDead = false;

	// PRIVATE INSTANCE VARIABLES
	private GameController gameController;
	private Transform target;
	private NavMeshAgent _agent;
	private Vector3 _destination;
	private Animator _anim;	
	private float startTime;

	void Start () {

		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent<GameController>();
		}
		if (gameController == null) {
			Debug.Log("Cannot find 'GameController' Script");
		}

		GameObject player = GameObject.FindWithTag ("Player");
		if (player != null) {
			target = player.GetComponent<Transform>();
		}
		if (gameController == null) {
			Debug.Log("Cannot find 'Player'");
		}

		this._anim = gameObject.GetComponent<Animator> ();
		this._agent = gameObject.GetComponent<NavMeshAgent> ();
		this._destination = this._agent.destination;
		
		this._agent.updateRotation = true;
		this._agent.updatePosition = true;

		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

		//print (Vector3.Distance (this.target.position, this.gameObject.transform.position));
		//Debug.Log(this.target.position + "   " + this.gameObject.transform.position);
		// Ensure target is at least 2 meters away

		float distance = Vector3.Distance (this.target.position, this.gameObject.transform.position);
		print (distance);
		if(isDead == false)
		{
			if (gameController.gameOver == true)
			{
				this._agent.speed = 1.5f;
				this._anim.Play ("Li_Walk");
				this._agent.destination = new Vector3(60, 2, 33);//this._destination;
			}
			else if (distance > 3.5f && distance < 20) 
			{
				this._agent.speed = 3.5f;
				this._agent.destination = target.position;
				this._anim.Play ("Li_Run");
			}
			else if (distance > 20)
			{
				this._agent.speed = 1.5f;
				this._anim.Play ("Li_Walk");
				this._agent.destination = new Vector3(60, 2, 33);//this._destination;
			}
			else
			{

				if(Time.time > startTime + 1.25 && gameController.gameOver == false && distance < 2.5f)
				{
					this._anim.Play ("Li_Attack");
					gameController.ChangeLife(-20);
					startTime = Time.time;
				}
			}
		}
	}


	public void LionDeath()
	{
		isDead = true;
		this._anim.Play ("Li_Dead");
		this._agent.updatePosition = false;
	}
}
