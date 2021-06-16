using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SalvarSkinPlayer : MonoBehaviour //não usado mais
{
	public int cabeloSkinQuant, cabeloCSkinQuant, peleSkinQuant, camisaSkinQuant, calcaSkinQuant, tenisSkinQuant;

	public GameObject cabeloObj, cabeloCObj, peleObj, camisaObj, calcaObj, tenisObj;
	public Skins cabeloSkin, cabeloCSkin, peleSkin, camisaSkin, calcaSkin, tenisSkin;
	public static SalvarSkinPlayer instance;
	string json;
	public PlayerSkin myPlayerS;

	CabeloProb cabeloProb;

	//Coin coinRef;
	//PlatformCount platCount;

	private void Awake()
	{
		if (instance == null)
		{
			DontDestroyOnLoad(this.gameObject);
			instance = this;
		}
		else if (instance != this)
		{
			Destroy(this.gameObject);
		}

		cabeloSkin = cabeloObj.gameObject.GetComponent<Skins>();
		cabeloCSkin = cabeloCObj.gameObject.GetComponent<Skins>();
		peleSkin = peleObj.gameObject.GetComponent<Skins>();
		camisaSkin = camisaObj.gameObject.GetComponent<Skins>();
		calcaSkin = calcaObj.gameObject.GetComponent<Skins>();
		tenisSkin = tenisObj.gameObject.GetComponent<Skins>();

		cabeloProb = FindObjectOfType<CabeloProb>();
	}

	void Start()
	{

		myPlayerS = JsonUtility.FromJson<PlayerSkin>(json);
		print(PlayerPrefs.GetInt("selection", 0));

	}

	void Update()
	{
		//if (coinValue == null)
		//{
		// 	coinValue = GameObject.FindObjectOfType<GBvalues>();
		//saveToFile();
		// }


		if (Input.GetKeyDown(KeyCode.M))
		{
			saveToFile();
			Debug.Log(cabeloSkin.quantCamisa + " cabelo");

		}

		if (Input.GetKeyDown(KeyCode.N))
		{
			loadFromFile();
		}

	}

	void saveToFile()
	{
		Debug.Log("Savor");
		myPlayerS = new PlayerSkin();

		myPlayerS.isCabeloCSave = cabeloProb.isCabeloC;

		if (cabeloProb.isCabeloC == false)
        {
			myPlayerS.cabelo = cabeloSkin.quantCamisa;
		}
        else
        {
			myPlayerS.cabeloC = cabeloCSkin.quantCamisa;
		}

		myPlayerS.pele = peleSkin.quantCamisa;
		myPlayerS.camisa = camisaSkin.quantCamisa;
		myPlayerS.calca = calcaSkin.quantCamisa;
		myPlayerS.tenis = tenisSkin.quantCamisa;

		cabeloSkinQuant = cabeloSkin.quantCamisa;
		cabeloCSkinQuant = cabeloCSkin.quantCamisa;
		peleSkinQuant = peleSkin.quantCamisa;
		camisaSkinQuant = camisaSkin.quantCamisa;
		calcaSkinQuant = calcaSkin.quantCamisa;
		tenisSkinQuant = tenisSkin.quantCamisa;

		json = JsonUtility.ToJson(myPlayerS);
		//print(json);

		System.IO.File.WriteAllText(Application.persistentDataPath + "/save.json", json);
		//print(Application.persistentDataPath);


	}

	public void loadFromFile()
	{
		Debug.Log("Caregor");
		string jsonRead = System.IO.File.ReadAllText(Application.persistentDataPath + "/save.json");
		myPlayerS = JsonUtility.FromJson<PlayerSkin>(jsonRead);

		cabeloProb.isCabeloC = myPlayerS.isCabeloCSave;

		if (cabeloProb.isCabeloC == false)
		{
			cabeloSkin.quantCamisa = myPlayerS.cabelo;
		}
		else
		{
			cabeloCSkin.quantCamisa = myPlayerS.cabeloC;
		}
				
		peleSkin.quantCamisa = myPlayerS.pele;
		camisaSkin.quantCamisa = myPlayerS.camisa;
		calcaSkin.quantCamisa = myPlayerS.calca;
		tenisSkin.quantCamisa = myPlayerS.tenis;



		//print("Load from File");
		//print(mySaveData.playerCoin);

		//coinRef = GameObject.FindObjectOfType<Coin>();
		//coinRef.updateCoinCounter();

		//platCount = GameObject.FindObjectOfType<PlatformCount>();
		//platCount.updatePlatformCounter();
	}

	/*void ClearOnLogout() //delete data
	{
		if (System.IO.File.Exists(Application.persistentDataPath + "/save.json"))
		{
			System.IO.File.Delete(Application.persistentDataPath + "/save.json");
		}
	}*/

	[Serializable]
	public class PlayerSkin //Classe com os dados salvos
	{
		public int cabelo = 0;
		public int cabeloC = 0;
		public int pele = 0;
		public int camisa = 0;
		public int calca = 0;
		public int tenis = 0;

		public bool isCabeloCSave = false;
	}


}



