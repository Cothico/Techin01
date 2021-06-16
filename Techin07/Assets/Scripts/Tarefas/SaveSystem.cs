using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour //Continuar adpatando //Verificando se precisa ser static...
{
	public static SaveSystem instance;
	string json;
	TasksData myTasksData;
    SlotData slotData;

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
	    
	    myTasksData = JsonUtility.FromJson<TasksData>(json);
	    print(PlayerPrefs.GetInt("selection",0));
	   
    }

    void Update()
    {
	    //if (coinValue == null)
	    //{
	   // 	coinValue = GameObject.FindObjectOfType<GBvalues>();
		    //saveToFile();
	   // }
	    
	    
	    if(Input.GetKeyDown(KeyCode.M))
	    {
	    	saveToFile();
	    }
	    
	    if(Input.GetKeyDown(KeyCode.N))
	    {
	    	loadFromFile();
	    }
	    
    }
    
	void saveToFile()
	{
		myTasksData = new TasksData();
		myTasksData.rewardData0 = slotData.slot0reward;
		myTasksData.rewardData1 = slotData.slot1reward;
		myTasksData.rewardData2 = slotData.slot2reward;
		myTasksData.rewardData3 = slotData.slot3reward;
		myTasksData.rewardData4 = slotData.slot4reward;
		myTasksData.rewardData5 = slotData.slot5reward;
		myTasksData.rewardData6 = slotData.slot6reward;
		myTasksData.rewardData7 = slotData.slot7reward;
		
		myTasksData.typeData0 = slotData.slot0type;
		myTasksData.typeData1 = slotData.slot1type;
		myTasksData.typeData2 = slotData.slot2type;
		myTasksData.typeData3 = slotData.slot3type;
		myTasksData.typeData4 = slotData.slot4type;
		myTasksData.typeData5 = slotData.slot5type;
		myTasksData.typeData6 = slotData.slot6type;
		myTasksData.typeData7 = slotData.slot7type;

		myTasksData.descriptionData0 = slotData.slot0description;
		myTasksData.descriptionData1 = slotData.slot1description;
		myTasksData.descriptionData2 = slotData.slot2description;
		myTasksData.descriptionData3 = slotData.slot3description;
		myTasksData.descriptionData4 = slotData.slot4description;
		myTasksData.descriptionData5 = slotData.slot5description;
		myTasksData.descriptionData6 = slotData.slot6description;
		myTasksData.descriptionData7 = slotData.slot7description;

		myTasksData.myActiveTasks = slotData.activeTasks;
		Debug.Log(myTasksData + " actives On Save");
		
		json = JsonUtility.ToJson(myTasksData);
		//print(json);
		
		System.IO.File.WriteAllText(Application.persistentDataPath + "/save.json", json);
		//print(Application.persistentDataPath);
	}
    
	void loadFromFile()
	{
		string jsonRead = System.IO.File.ReadAllText(Application.persistentDataPath + "/save.json");
		myTasksData = JsonUtility.FromJson<TasksData>(jsonRead);
		
		slotData.slot0reward = myTasksData.rewardData0;
		slotData.slot1reward = myTasksData.rewardData1;
		slotData.slot2reward = myTasksData.rewardData2;
		slotData.slot3reward = myTasksData.rewardData3;
		slotData.slot4reward = myTasksData.rewardData4;
		slotData.slot5reward = myTasksData.rewardData5;
		slotData.slot6reward = myTasksData.rewardData6;
		slotData.slot7reward = myTasksData.rewardData7;

		slotData.slot0type = myTasksData.typeData0;
		slotData.slot1type = myTasksData.typeData1;
		slotData.slot2type = myTasksData.typeData2;
		slotData.slot3type = myTasksData.typeData3;
		slotData.slot4type = myTasksData.typeData4;
		slotData.slot5type = myTasksData.typeData5;
		slotData.slot6type = myTasksData.typeData6;
		slotData.slot7type = myTasksData.typeData7;

		slotData.slot0description = myTasksData.descriptionData0;
		slotData.slot1description = myTasksData.descriptionData1;
		slotData.slot2description = myTasksData.descriptionData2;
		slotData.slot3description = myTasksData.descriptionData3;
		slotData.slot4description = myTasksData.descriptionData4;
		slotData.slot5description = myTasksData.descriptionData5;
		slotData.slot6description = myTasksData.descriptionData6;
		slotData.slot7description = myTasksData.descriptionData7;
		
		slotData.activeTasks = myTasksData.myActiveTasks;
		Debug.Log(slotData.activeTasks + " actives On Load");
		//print("Load from File");
		//print(mySaveData.playerCoin);
		
		//coinRef = GameObject.FindObjectOfType<Coin>();
		//coinRef.updateCoinCounter();
		
		//platCount = GameObject.FindObjectOfType<PlatformCount>();
		//platCount.updatePlatformCounter();
	}

	void ClearOnLogout() //delete data
	{
		if(System.IO.File.Exists(Application.persistentDataPath + "/save.json"))
		{
			System.IO.File.Delete(Application.persistentDataPath + "/save.json");
		}
	}	

	private class TasksData //Classe com os dados salvos
	{
		public int rewardData0, rewardData1, rewardData2, rewardData3, rewardData4, rewardData5, rewardData6, rewardData7;
		public int typeData0, typeData1, typeData2, typeData3, typeData4, typeData5, typeData6, typeData7;
        public string descriptionData0, descriptionData1, descriptionData2, descriptionData3, descriptionData4, descriptionData5, descriptionData6, descriptionData7;
		public int myActiveTasks;
	}

    private class AlreadyOpened
    {
        bool firstTime;
    }
    
}
