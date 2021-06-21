using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveSystem : MonoBehaviour //Continuar adpatando //Verificando se precisa ser static...
{
	public static SaveSystem instance;
	string json;
	public TasksData myTasksData;
    SlotData slotData;
	string dataFile = "7572857242.dat";
	

	//Coin coinRef;
	//PlatformCount platCount;

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
	
    void Start()
    {
	    slotData = FindObjectOfType<SlotData>();
	    //myTasksData = JsonUtility.FromJson<TasksData>(json);
	    //print(PlayerPrefs.GetInt("selection",0));
	   
    }

	/*private void Update() {
		if(Input.GetKeyDown(KeyCode.Z))
		{
			Delete();
		}
	}*/
    
	public void SaveTasks()
	{
		string filePath = Application.persistentDataPath + "/" + dataFile;
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(filePath);
        bf.Serialize(file, myTasksData);
        file.Close();

        Debug.Log("Saved");
		Debug.Log(myTasksData.myActiveTasks);
	}

	public void LoadTasks()
	{	
        string filePath = Application.persistentDataPath + "/" + dataFile;
        BinaryFormatter bf = new BinaryFormatter();
        if(File.Exists(filePath))
        {
            FileStream file = File.Open(filePath, FileMode.Open);
            TasksData loaded = (TasksData)bf.Deserialize(file);
            myTasksData = loaded;
            file.Close();

            Debug.Log("Loaded");
			Debug.Log(myTasksData.myActiveTasks);
        }
	}

	/*public void Delete()
    {
        string filePath = Application.persistentDataPath + "/" + dataFile;
        BinaryFormatter bf = new BinaryFormatter();
        if(System.IO.File.Exists(filePath))
        {
            File.Delete(filePath);
        }
    }*/

	

	[System.Serializable]
	public class TasksData //Classe com os dados salvos
	{
		public int rewardData0, rewardData1, rewardData2, rewardData3, rewardData4, rewardData5, rewardData6, rewardData7;
		public int typeData0, typeData1, typeData2, typeData3, typeData4, typeData5, typeData6, typeData7;
        public string descriptionData0, descriptionData1, descriptionData2, descriptionData3, descriptionData4, descriptionData5, descriptionData6, descriptionData7;
		public int myActiveTasks;
		public TasksData(BlocoTarefas blocoTarefas)
		{
			rewardData0 = 0;
			rewardData1 = 0;
			rewardData2 = 0;
			rewardData3 = 0;
			rewardData4 = 0;
			rewardData5 = 0;
			rewardData6 = 0;
			rewardData7 = 0;
			typeData0 = 0;
			typeData1 = 0;
			typeData2 = 0;
			typeData3 = 0;
			typeData4 = 0;
			typeData5 = 0;
			typeData6 = 0;
			typeData7 = 0;
			descriptionData0 = "";
			descriptionData1 = "";
			descriptionData2 = "";
			descriptionData3 = "";
			descriptionData4 = "";
			descriptionData5 = "";
			descriptionData6 = "";
			descriptionData7 = "";
			myActiveTasks = 0;
		}
	}


    /*private class AlreadyOpened
    {
        bool firstTime;
    }*/
    
}
