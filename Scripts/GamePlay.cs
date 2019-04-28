using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
	private static GamePlay instance;

	public static GamePlay Instance {
		get {
			if (instance == null)
				instance = GameObject.FindObjectOfType<GamePlay> ();

			return instance;
		}
	}

	int lives;
	int successfullyputtedNumber;
	public GameObject[] lifesimages;
	public int totalMatchingNumbers;
	public GameObject levelComplete;
	public GameObject levelFailed;

	// Use this for initialization
	void Start ()
	{
		lives = 3;
		successfullyputtedNumber = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void DecreaseLife ()
	{
		lives--;
        if (SoundManager.Instance)
       	SoundManager.Instance.PlayLevelFailedSound1 ();
		lifesimages [lives].SetActive (false);
		if (lives < 1) {
			Invoke ("GameOver", 1);
            if (SoundManager.Instance)
                SoundManager.Instance.PlayLevelFailedSound ();

		}
	}

	public void IncreaseSuccessRate ()
	{
		successfullyputtedNumber++;
        if (SoundManager.Instance)
            SoundManager.Instance.PlayLevelCompleteSound1 ();

		if (successfullyputtedNumber >= totalMatchingNumbers) {
			Invoke ("GameWin", 1);
            if (SoundManager.Instance)
                SoundManager.Instance.PlayLevelCompleteSound ();

		}
	}

	void GameOver ()
	{
		Debug.Log ("game is over");
		levelFailed.SetActive (true);



	}

	void GameWin ()
	{
		Debug.Log ("game won");
		levelComplete.SetActive (true);

	}
}
