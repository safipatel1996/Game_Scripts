using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void Home ()
	{
		SoundManager.Instance.PlayButtonClickSound ();
		SceneManager.LoadScene ("MainMenu");
	}

	public void TryAgain ()
	{
        if (SoundManager.Instance)
        {
            SoundManager.Instance.PlayButtonClickSound();

            SoundManager.Instance.PlayButtonClickSound();
        }
		if (SceneManager.GetActiveScene ().name.Equals ("Round_1")) {
			SceneManager.LoadScene ("Round_1");
		} else if (SceneManager.GetActiveScene ().name.Equals ("Round_2")) {
			SceneManager.LoadScene ("Round_2");

		} else if (SceneManager.GetActiveScene ().name.Equals ("Round_3")) {
			SceneManager.LoadScene ("Round_3");

		} else if (SceneManager.GetActiveScene ().name.Equals ("Round_4")) {
			SceneManager.LoadScene ("Round_4");
		}
	}
}
