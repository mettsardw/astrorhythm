using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongBlock : MonoBehaviour {

	public Text songInfo;
	public int stage;
	public int number;

	public Button nextButton;
	public Button prevButton;

	public Button buttonContainer;
	public bool done = false;
	public static int currentStage;
	// Use this for initialization
	void Start () {
		foreach (SongEntry song in XMLManager.manager.songDB.songs) {
			if (song.stage == stage && song.number == number) {
				showInfo (song);
			}
			//Debug.Log (song.stage + ", " + stage + " | " + song.number + ", " + number);
		}
		if (stage == 1)
			prevButton.gameObject.SetActive (false);
		else if (stage == 8)
			nextButton.gameObject.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(currentStage == 1)
			prevButton.gameObject.SetActive (false);
		else if(currentStage == 8)
			nextButton.gameObject.SetActive (false);
		else {
			prevButton.gameObject.SetActive (true);
			nextButton.gameObject.SetActive (true);
		}
		
		//if(stage != 8)
			//nextButton.onClick.AddListener (GoToNextStage);
		//if(stage != 1)
			//prevButton.onClick.AddListener (GoToPrevStage);
		//if(stage ==1)
		//	prevButton.gameObject.SetActive (false);
	}

	public void showInfo(SongEntry song){
		songInfo = GetComponent<Text> ();
		songInfo.text = song.songName;
	}

	public void AddStage(){
		currentStage = ++stage;
	}

	public void DecreaseStage(){
		currentStage = --stage; 
		//Debug.Log (currentStage);
	}

	public void GoToNextStage(){
		foreach (SongEntry song in XMLManager.manager.songDB.songs) {
			if (song.stage == currentStage && song.number == number) {
				showInfo (song);
			}
		}
		
	}

	public void GoToPrevStage(){
		foreach (SongEntry song in XMLManager.manager.songDB.songs) {
			if (song.stage == currentStage && song.number == number) {
				showInfo (song);
				//Debug.Log (song.stage + ", " + stage + " | " + song.number + ", " + number);
			}

		}
	}
}
