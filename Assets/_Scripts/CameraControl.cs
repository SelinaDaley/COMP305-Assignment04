using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CameraControl : MonoBehaviour {

	public static CameraControl control;
	public Light nightVision;
	public Image imageBino;
	public Camera camera;
	public GameObject tripWire;

	public int zoom = 20;
	public int normal = 60;
	public float smooth = 5f;	

	private bool isZoomed = false;	
	private bool binoOn = false;
	private bool nightVisionOn = false;

	// Use this for initialization
	void Start () 
	{
		imageBino.enabled = false;
		tripWire.GetComponent<MeshRenderer>().enabled = false;
	}

	// Update is called once per frame
	void Update () 
	{
		// Toggle binoculars
		if (Input.GetKeyDown (KeyCode.B)) 
		{
			binoOn = !binoOn;
			imageBino.enabled = binoOn;

			// Turn night vision and zoom to false when exiting the binoculars
			if(binoOn == false)
			{
				nightVisionOn = false;
				isZoomed = false;
			}
		}

		// Toggle the zoom and night vision boolean values
		if(Input.GetKeyDown(KeyCode.Alpha1) && binoOn == true)
		{
			isZoomed = !isZoomed;
		}
		if(Input.GetKeyDown(KeyCode.Alpha2) && binoOn == true)
		{
			nightVisionOn = !nightVisionOn;
		}

		// Enable or disable night vision
		if (nightVisionOn == true) 
		{
			nightVision.enabled = true;
		} 
		else 
		{
			nightVision.enabled = false;
		}

		// Enable or disable the zoom fuction
		if(isZoomed == true)
		{
			camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, zoom, Time.deltaTime * smooth);
		}
		else
		{
			camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, normal, Time.deltaTime * smooth);
		}

	}
}
