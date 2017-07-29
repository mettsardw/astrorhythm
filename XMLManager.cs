using System.Collections;

using System.Collections.Generic; // for lists
using System.Xml; // basic xml attr
using System.Xml.Serialization; //xml serializer
using System.IO; //file management

using UnityEngine;

public class XMLManager : MonoBehaviour {

	public static XMLManager manager;

	// Use this for initialization
	void Awake(){
		manager = this;
	}

	public SongDatabase songDB;
}

[System.Serializable]
public class SongEntry{
	public string songName;
	public string key;
	public string tempo;
	public int stage;
	public int number;
}

[System.Serializable]
public class SongDatabase{
	public List<SongEntry> songs = new List<SongEntry>();
}