using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SavePrefs : MonoBehaviour
{
    public static SavePrefs instance;
    string json;
    public PrefData prefData;
    string dataFilePrefs = "5750039060.dat";
    // Start is called before the first frame update
    private void Awake() {
		if(instance == null)
		{
			DontDestroyOnLoad(this.gameObject);
			instance = this;
		}
		else if(instance != this)
		{
			Destroy(this.gameObject);
		}
	}

    // Update is called once per frame
    public void Save()
	{
		string filePath2 = Application.persistentDataPath + "/" + dataFilePrefs;
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(filePath2);
        bf.Serialize(file, prefData);
        file.Close();

        Debug.Log("Prefs Saved");
	}

	/*private void Update() {
		if(Input.GetKeyDown(KeyCode.X))
		{
			Delete();
		}
	}*/

	public void Load()
	{
		string filePath2 = Application.persistentDataPath + "/" + dataFilePrefs;
        BinaryFormatter bf = new BinaryFormatter();
        if(File.Exists(filePath2))
        {
            FileStream file = File.Open(filePath2, FileMode.Open);
            PrefData loaded = (PrefData)bf.Deserialize(file);
            prefData = loaded;
            file.Close();

            Debug.Log("Prefs Loaded");
        }
	}
	/*public void Delete()
    {
        string filePath2 = Application.persistentDataPath + "/" + dataFilePrefs;
        BinaryFormatter bf = new BinaryFormatter();
        if(System.IO.File.Exists(filePath2))
        {
            File.Delete(filePath2);
        }
    }*/

    [System.Serializable]
	public class PrefData
	{
		public bool isGameStart;
		public string userEmail;
		public string userPassword;
		public string parentalPassword;
		public PrefData(AuthManager authManager)
		{
			isGameStart = false;
			userEmail = "";
			userPassword = "";
			parentalPassword = "";
		}
	}
}
