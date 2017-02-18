using UnityEngine;
using System.Collections;

public class PlayerController2 : MonoBehaviour {

	public float inputDelay = 0.1f;
	public float forwardVel = 12;
	public float rotateVel = 100;
	public float runVel = 22;
	private Animator anim;

	Quaternion targetRotation;
	Rigidbody rBody;
	float forwardInput, turnInput;

	public Quaternion TargetRotation
	{
		get { return targetRotation; }
	}

	void Start()
	{
		anim = GetComponentInChildren <Animator> ();

		targetRotation = transform.rotation;
		if (GetComponent<Rigidbody> ())
			rBody = GetComponent<Rigidbody> ();
		else 
			Debug.LogError ("The Player needs a rigidbody.");

		forwardInput = turnInput = 0;
	}

	void GetInput()
	{
		forwardInput = Input.GetAxis("Vertical");
		turnInput = Input.GetAxis ("Horizontal");
	}

	void Update()
	{
		GetInput ();
		Turn ();
		if (forwardInput == 0) {
			anim.SetBool ("Run", false);
			anim.SetBool ("Walk", false);
		}
	}

	void FixedUpdate()
	{
		Walk ();
		Animations ();
	}

	void Walk()
	{
		if (Mathf.Abs (forwardInput) > inputDelay) {
			rBody.velocity = transform.TransformDirection(new Vector3 (0, rBody.velocity.y, forwardInput * forwardVel));
		} else
			//zero velocity
			rBody.velocity = new Vector3(0,rBody.velocity.y,0);
		if (Input.GetKey (KeyCode.LeftShift)) {
			forwardVel = 4;
			rotateVel = 150;
		} else {
			forwardVel = 2;
			rotateVel = 100;
		}
	}

	void Animations()
	{
		if (Input.GetKey (KeyCode.LeftShift)) {
			anim.SetBool ("Run", true);
		}
		
		if (Mathf.Abs (forwardInput) > inputDelay) {
			anim.SetBool ("Walk", true);
		}
	}
	
	void Turn()
	{
		if (Mathf.Abs (turnInput) > inputDelay) {
			targetRotation *= Quaternion.AngleAxis (rotateVel * turnInput * Time.deltaTime, Vector3.up);
		}
		transform.rotation = targetRotation;
	}
}
