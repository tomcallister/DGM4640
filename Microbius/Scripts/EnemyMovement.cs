using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public float speed = 1;
	private Animator anim;

	void Start () {
		anim = GetComponentInChildren <Animator> ();
	}

	void Update () {
		anim.SetBool ("EnemyWalk", true);
		transform.Translate (0, 0, speed);
	}
}
