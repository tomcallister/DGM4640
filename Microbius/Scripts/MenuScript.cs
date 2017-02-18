using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Canvas aboutMenu;
	public Button exitText;
	public Button startText;
	public Button aboutText;

	// Use this for initialization
	void Start () {
	
		aboutMenu = aboutMenu.GetComponent<Canvas> ();
		exitText = exitText.GetComponent<Button> ();
		startText = startText.GetComponent<Button> ();
		aboutText = aboutText.GetComponent<Button> ();
		aboutMenu.enabled = false;

	}

	public void StartLevel()
	{
		Application.LoadLevel (1);
	}

	public void AboutTextPress()
	{
		aboutMenu.enabled = true;

	}

	public void ExitGame()
	{
		Application.Quit ();
	}

	// Update is called once per frame
	void Update () {
	
	}
}
