using UnityEngine.UI;

using System.Collections;
using UnityEngine;

public class SongBlock : MonoBehaviour {

	//public Text songName, key, tempo, stage, number;
	public Text songInfo;

	void Start(){
		//songName.text = " jsdhsjdh";
		//key.text = " jsdhsjdh";
	}

	public void display(SongEntry song){
		songInfo = GetComponent<Text> ();
		songInfo.text = song.songName + " / " + song.key + "\n" + song.tempo + " " + song.stage.ToString () + "-" + song.number.ToString ();
		//Debug.Log (song.songName);
		//songName = GetComponent<Text> ();
		//key = GetComponent<Text> ();
		//tempo = GetComponent<Text> ();
		//stage = GetComponent<Text> ();
		//number = GetComponent<Text> ();
		//Debug.Log (SongName);
		//SongName.text;
		//songName.text = song.songName;
		//key.text = song.key;
		//tempo.text = song.tempo;
		//stage.text = song.stage.ToString() + "-";
		//number.text = "-" + song.number.ToString();
	}
}
