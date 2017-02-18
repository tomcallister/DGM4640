using UnityEngine;
using System.Collections;

public class EnemyAttackTrigger : MonoBehaviour {

	private Animator anim;
	public Transform target;
	public float speed = 2f;
	//bool attackMode;
	//public string MyTrigger;
	//public string EnemyAttack;

	void Start (){
	//	attackMode = false;
		anim = GetComponentInChildren <Animator> ();
	}

	void OnTriggerEnter (Collider col){
		if (col.transform.CompareTag ("Player")) {
			//	attackMode = true;
			//	GetComponentInChildren <Animator>().SetTrigger(EnemyAttack);
			//	anim.SetTrigger ("EnemyAttack");
			anim.SetBool ("EnemyAttack1", true);
			MoveToPlayer ();
		}
		else if (col.transform.CompareTag ("Ground")) {
			anim.SetBool ("EnemyWalk", false);
		}
	}

	void OnTriggerExit (Collider col)
	{
		if (col.transform.CompareTag ("Player")) 
		{
			anim.SetBool ("EnemyAttack1", false);
		}
	}

	public void MoveToPlayer ()
	{
		//rotate to look at player
		transform.LookAt (target.position);
		//transform.LookAt (target);
		transform.Rotate (new Vector3 (0, 0, 0), Space.Self);
		
		//move towards player
		//transform.Translate (new Vector3 (speed * Time.deltaTime, 0, 0));
	}
}
