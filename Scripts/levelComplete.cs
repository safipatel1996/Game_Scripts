using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
	public string[] inspiringMsgs;

	public Text msg;
	public Image nextButton;
	public Sprite playagainImage;

	// Use this for initialization
	void Start ()
	{
		msg.text = inspiringMsgs [Random.Range (0, inspiringMsgs.Length)];
		if (SceneManager.GetActiveScene ().name.Equals ("Round_4")) {
			nextButton.sprite = playagainImage;
		}

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void HomeButton ()
	{
        if (SoundManager.Instance)
            SoundManager.Instance.PlayButtonClickSound ();
		SceneManager.LoadScene ("MainMenu");
	}

	public void NextRound ()
	{
        if (SoundManager.Instance)
            SoundManager.Instance.PlayButtonClickSound ();
		if (SceneManager.GetActiveScene ().name.Equals ("Round_1")) {
			SceneManager.LoadScene ("Round_2");
		} else if (SceneManager.GetActiveScene ().name.Equals ("Round_2")) {
			SceneManager.LoadScene ("Round_3");

		} else if (SceneManager.GetActiveScene ().name.Equals ("Round_3")) {
			SceneManager.LoadScene ("Round_4");

		} else if (SceneManager.GetActiveScene ().name.Equals ("Round_4")) {
			SceneManager.LoadScene ("MainMenu");
		}

	}
}
