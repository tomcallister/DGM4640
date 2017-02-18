using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	public Quaternion startRotation;

	public void Start(){
		startRotation = transform.rotation;
	}

	void OnTriggerEnter (Collider collider) {
		if (collider.name == "DeathZone") {
			transform.position = new Vector3 (11.07f, 3.43f, 27.93f);
//			transform.rotation = GetComponent <PlayerController2.>
//			transform.rotation = startRotation;
		}


	}

}
