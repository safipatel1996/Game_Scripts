using UnityEngine;
using System.Collections;

[RequireComponent (typeof(AudioSource))]

public class SoundManager : MonoBehaviour
{

	private static SoundManager instance;

	public static SoundManager Instance {
		get {
			if (instance == null)
				instance = GameObject.FindObjectOfType<SoundManager> ();

			return instance;
		}
	}


	public AudioSource inGameLoopAudioSource;
	public bool isMultipleSounds = false;
	public bool isSound = true;

	#region OneShotSoundClips

	/*
	 * Audio Clip Files for One Shot
	 */

	public AudioClip buttonClickSound;
	//public AudioClip scratchSound;

	public AudioClip levelFailedSound1;

	public AudioClip levelFailedSound;
	public AudioClip levelSuccessSound;
	public AudioClip levelSuccessSound1;

	//	public AudioClip popUpSound;
	//	public AudioClip iapSuccessSound;
	//	public AudioClip dailyBonusSound;
	//	public AudioClip characterSelected;
	//	public AudioClip tooldone;
	//	public AudioClip cameraSound;
	//	public AudioClip NextButtonSound;
	//
	//	public AudioClip coinCollectedSound;

	#endregion

	#region InGameLoopSoundClips

	/*
	 * Audio Clip Files for In Game Loop Sound
	 */
	//public AudioClip creamApplySound;

	#endregion

	#region BackGroundSoundClips

	/*
	 * Audio Clip Files for BG Loop Sound
	 */
	//	public AudioClip menuBGSound;
	//	public AudioClip gameBGSound;
	//	public AudioClip endGameBGSound;
	//

	#endregion


	//	public AudioClip[] mensterPattrenSound;

	#region DefaultMethods

	//TODO: Make sure you override your awake by override keyword
	/*override*/
	void Awake ()
	{
		if (GameObject.FindGameObjectsWithTag ("SoundManager").Length > 1) {
			Destroy (gameObject);
		} else {
			DontDestroyOnLoad (gameObject);
		}
	}

	void Start ()
	{

		//PlayerPrefs.DeleteAll ();
		/*
         * If Sound is mute previously Mute the sound.
         */
		//TODO : Need to change issound with your player prefrence
		if (!isSound) {
			GetComponent<AudioSource> ().mute = true;
		} else {
			GetComponent<AudioSource> ().mute = false;
		}

		/*
		 * Checking whether dual sound enable or not.
		 * If Enable setting MenuBGSound and GameBGSound Accourding.
		 * Else always set GameBGSound.
		 */
//
//		if (isMultipleSounds) {
//			this.PlayMenuBackgroundSound ();
//		} else {
//			this.PlayBackgroundSound ();
//		}
        

		/*
		 * If Sound is not playing Play the musicAudioSource
		 */

		if (!GetComponent<AudioSource> ().isPlaying) {
			GetComponent<AudioSource> ().Play ();
		}
	}

	#endregion



	#region InGameLoopSoundMethods

	/*
	 * Stop Playing previous in game loop sound
     * checking is new in game loop sound available playing it.
	 */
    
	//	public void PlayCreamApplySound ()
	//	{
	//		StopInGameLoop ();
	//
	//		if (creamApplySound) {
	//			inGameLoopAudioSource.clip = creamApplySound;
	//			inGameLoopAudioSource.Play ();
	//		}
	//	}

	//	public void PlayscratchSound ()
	//	{
	//		StopInGameLoop ();
	//
	//		if (scratchSound) {
	//			inGameLoopAudioSource.clip = scratchSound;
	//			inGameLoopAudioSource.Play ();
	//		}
	//	}


	public void StopInGameLoop ()
	{
		inGameLoopAudioSource.Stop ();
	}

	#endregion

	#region BGSoundMethods

	/*
	 * Playing Different Background Sounds
	 */

	//	public void PlayBackgroundSound ()
	//	{
	//		if (gameBGSound) {
	//			GetComponent<AudioSource> ().clip = gameBGSound;
	//			GetComponent<AudioSource> ().Play ();
	//
	//		}
	//	}
	//
	//	public void PlayEndGameSound ()
	//	{
	//		if (endGameBGSound) {
	//			GetComponent<AudioSource> ().clip = endGameBGSound;
	//		}
	//	}
	//
	//	public void PlayMenuBackgroundSound ()
	//	{
	//		if (menuBGSound) {
	//			GetComponent<AudioSource> ().clip = menuBGSound;
	//			GetComponent<AudioSource> ().Play ();
	//
	//		}
	//	}

	#endregion

	#region OneShotSoundMethods

	/*
	 * Playing one shot for each OneShotSound.
     * Muting and UnMuting sound Accordingly.
	 */
	//	public void PlayCharacterSelectedSound ()
	//	{
	//		if (characterSelected) {
	//			Debug.Log ("playSound");
	//
	//			GetComponent<AudioSource> ().PlayOneShot (characterSelected);
	//		}
	//	}

	//	public void PlayNextButtonSound ()
	//	{
	//		if (NextButtonSound) {
	//			GetComponent<AudioSource> ().PlayOneShot (NextButtonSound);
	//		}
	//	}
	//
	//	public void PlayPattrenMonsterSound (int monsterNumber)
	//	{
	//		if (mensterPattrenSound [monsterNumber]) {
	//			GetComponent<AudioSource> ().PlayOneShot (mensterPattrenSound [monsterNumber]);
	//		}
	//	}
	//
	//	public void PlayCameraSound ()
	//	{
	//		if (cameraSound) {
	//			GetComponent<AudioSource> ().PlayOneShot (cameraSound);
	//		}
	//	}
	//
	//	public void PlayTooldoenSound ()
	//	{
	//		if (tooldone) {
	//			GetComponent<AudioSource> ().PlayOneShot (tooldone);
	//		}
	//	}


	public void PlayButtonClickSound ()
	{
		if (buttonClickSound) {
			GetComponent<AudioSource> ().PlayOneShot (buttonClickSound);
		}
	}

	//	public void PlayscratchSound ()
	//	{
	//		if (scratchSound) {
	//			GetComponent<AudioSource> ().PlayOneShot (scratchSound);
	//		}
	//	}

	//	public void PlayCoinCollectedSound ()
	//	{
	//		if (coinCollectedSound) {
	//			//			Debug.Log ("button click");
	//			GetComponent<AudioSource> ().PlayOneShot (coinCollectedSound);
	//		}
	//	}
	//

	public void PlayLevelFailedSound ()
	{
		if (levelFailedSound) {
			GetComponent<AudioSource> ().PlayOneShot (levelFailedSound);
		}
	}

	public void PlayLevelFailedSound1 ()
	{
		if (levelFailedSound1) {
			GetComponent<AudioSource> ().PlayOneShot (levelFailedSound1);
		}
	}

	public void PlayLevelCompleteSound ()
	{
		if (levelSuccessSound) {
			GetComponent<AudioSource> ().PlayOneShot (levelSuccessSound);
		}
	}

	public void PlayLevelCompleteSound1 ()
	{
		if (levelSuccessSound1) {
			GetComponent<AudioSource> ().PlayOneShot (levelSuccessSound1);
		}
	}

	//	public void PlayPopUpSound ()
	//	{
	//		if (popUpSound) {
	//			GetComponent<AudioSource> ().PlayOneShot (popUpSound);
	//		}
	//	}
	//
	//	public void PlayIAPSucessSound ()
	//	{
	//		if (iapSuccessSound) {
	//			GetComponent<AudioSource> ().PlayOneShot (iapSuccessSound);
	//		}
	//	}
	//
	//	public void PlayDailyBonusSound ()
	//	{
	//		if (dailyBonusSound) {
	//			GetComponent<AudioSource> ().PlayOneShot (dailyBonusSound);
	//		}
	//	}

	public void PlayMuteSound ()
	{
		isSound = false;
		GetComponent<AudioSource> ().mute = true;
		//TODO : Need to save the sound states 
	}

	public void PlayUnMuteSound ()
	{
		isSound = true;
		GetComponent<AudioSource> ().mute = false;
		//TODO : Need to save the sound states 
	}

	#endregion
}