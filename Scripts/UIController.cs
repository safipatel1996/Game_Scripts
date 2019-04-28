using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void PlayButtonClicked ()
	{
		SoundManager.Instance.PlayButtonClickSound ();
		//Debug.Log ("PlayButtonClicked");
		//Round_1
		SceneManager.LoadScene ("Round_1");

	}

	public void OptionButtonClicked ()
	{
		SoundManager.Instance.PlayButtonClickSound ();

		//Debug.Log ("OptionButtonClicked");
		SceneManager.LoadScene ("TutorialScene");

	}

	public void QuitButtonClicked ()
	{
		SoundManager.Instance.PlayButtonClickSound ();

		//Debug.Log ("QuitButtonClicked");
		Application.Quit ();
	}
}
