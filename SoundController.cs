using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour {

	[SerializeField]
	private AudioSource audioM;
	[SerializeField]
	private Sprite soundOn, soundOFF;
	[SerializeField]
	private Image audioBtnImage;

	// Use this for initialization
	void Start () {
		audioM.Play ();
	}

	public void muteaudio ()
	{
		if (audioM.isPlaying) {
			audioBtnImage.sprite = soundOFF;
			audioM.Stop ();
		}
		else {
			audioBtnImage.sprite = soundOn;
			audioM.Play ();
		}
			
	}


}
