using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CameraController : MonoBehaviour {

	public float cameraDistOffset_x = 10;
	public float cameraDistOffset_y = 10;
	public float cameraDistOffset_z = 0;
	private Camera mainCamera;
	private GameObject player;
	
	// Use this for initialization
	void Start () {
		mainCamera = GetComponent<Camera>();
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerInfo = player.transform.transform.position;
		mainCamera.transform.position = new Vector3(playerInfo.x - cameraDistOffset_x, playerInfo.y - cameraDistOffset_y, playerInfo.z - cameraDistOffset_z);
	}

}
