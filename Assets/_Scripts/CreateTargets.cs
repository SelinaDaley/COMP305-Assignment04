using UnityEngine;
using System.Collections;

public class CreateTargets : MonoBehaviour {

	public GameObject blackTarget;
	public GameObject greenTarget;
	public GameObject redTarget;

	private float xPos;
	private float yPos;
	private float zPos;

	// Use this for initialization
	void Start () {

		/*for(int i = 0; i < 5; i++)
		{
			xPos = Random.Range(-28, -5);
			yPos = Random.Range(2.5f, 4);
			zPos = Random.Range(-27, 3);

			Instantiate(blackTarget, new Vector3(xPos, yPos, zPos), Quaternion.Euler( new Vector3(90f, 180f, 0f)));
		}*/

		for(int i = 0; i < 15; i++)
		{
			xPos = Random.Range(-28, -5);
			yPos = Random.Range(2.5f, 4);
			zPos = Random.Range(-27, 3);
			
			Instantiate(greenTarget, new Vector3(xPos, yPos, zPos), Quaternion.Euler( new Vector3(90f, 180f, 0f)));
		}

		for(int i = 0; i < 10; i++)
		{
			xPos = Random.Range(1, 4);
			yPos = Random.Range(2.5f, 4);
			zPos = Random.Range(-22, 9);
			
			Instantiate(redTarget, new Vector3(xPos, yPos, zPos), Quaternion.Euler( new Vector3(90f, 90f, 0f)));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
