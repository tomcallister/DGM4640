using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ReturnMenu : MonoBehaviour {

	public Button returnText; 

	// Use this for initialization
	void Start () {
	
		returnText = returnText.GetComponent<Button> ();
	}

	public void ReturnPress ()
	{
		Application.LoadLevel (0);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
