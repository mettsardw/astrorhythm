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
		loadSongs ();
		//saveSongs();
	}

	public SongDatabase songDB;
	public GameDatabase gameDB;

	//save song list
	public void saveSongs(){
		//open xml file
		XmlSerializer serializer = new XmlSerializer (typeof(SongDatabase));
		FileStream stream = new FileStream (Application.dataPath + "/Files/song_list.xml", FileMode.Create);
		serializer.Serialize (stream, songDB);
		stream.Close ();
	}

	//load song list
	public void loadSongs(){
		//open xml file
		XmlSerializer serializer = new XmlSerializer (typeof(SongDatabase));
		FileStream stream = new FileStream (Application.dataPath + "/Files/song_list.xml", FileMode.Open);
		songDB = serializer.Deserialize(stream) as SongDatabase;
		stream.Close ();
	}
	
	//save game
	public void saveGame(){
		XmlSerializer serializer = new XmlSerializer (typeof(GameDatabase));
		FileStream stream = new FileStream (Application.dataPath + "/Files/gamedata.xml", FileMode.Create);
		serializer.Serialize (stream, gameDB);
		stream.Close ();
	}
	
	//load game
	public void loadSongs(){
		//open xml file
		XmlSerializer serializer = new XmlSerializer (typeof(GameDatabase));
		FileStream stream = new FileStream (Application.dataPath + "/Files/gamedata.xml", FileMode.Open);
		songDB = serializer.Deserialize(stream) as GameDatabase;
		stream.Close ();
	}
}
	
[System.Serializable]
public class HighScoreEntry{
	public string playerName;
	public int playerScore;
}

[System.Serializable]
public class SongEntry{
	public string songName;
	public string key;
	public string tempo;
	public int stage;
	public int number;
	public int star = -1;
	public List<HighScoreEntry> highScores = new List<HighScoreEntry>();
}

[System.Serializable]
public class SongDatabase{
	public List<SongEntry> songs = new List<SongEntry>();
}

[System.Serializable]
public class GameDatabase{
	public int totalStars;
	public int currentLevel;
}
