using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]

public class CharController : MonoBehaviour {

	private Vector3 tempPos;
	private CharacterController myCC;
	public float speed = 1;
	public float jumpSpeed = 1;
	public float gravity = 1;
	public float rotateSpeed = 1;

	// Use this for initialization
	void Start () {
		myCC = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown(KeyCode.Space) && myCC.isGrounded) {
//			tempPos.y = jumpSpeed;
//		}

		tempPos.y -= gravity;

		myCC.Move (tempPos * Time.deltaTime);

	}
}
