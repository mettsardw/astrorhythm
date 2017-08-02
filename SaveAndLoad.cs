using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveAndLoad{
	public static List<Game> saves = new List<Game>();

	public static void SaveGame(){
		saves.Add (Game.current);
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/astroSave.sav");
		bf.Serialize (file, SaveAndLoad.saves);

		file.Close ();
	}

	public static void LoadGame(){
		if (File.Exists (Application.persistentDataPath + "/astroSave.sav")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/astroSave.sav",FileMode.Open);
			SaveAndLoad.saves = (List<Game>)bf.Deserialize (file);

			file.Close ();
		}
	}
}

