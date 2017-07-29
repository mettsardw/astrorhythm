using System.Collections;
using UnityEngine;

public class SongDisplay : MonoBehaviour {

	public SongBlock songBlock;

	// Use this for initialization
	void Start () {
		showList ();
	}

	public void showList(){
		foreach (SongEntry song in XMLManager.manager.songDB.songs) {
			//Debug.Log (song.songName);

			songBlock = GetComponent<SongBlock> ();
			songBlock.display (song);

			//SongBlock newSong = Instantiate (songBlock) as SongBlock;

			//newSong.transform.SetParent (transform, false);
			//newSong.display (song);
		}

	}
}
