using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveSkinLoad : MonoBehaviour
{
    public static SaveSkinLoad instance;
    public PData pData;
    string dataFile = "6461746131.dat";

    //public int[] slots;
    private void Awake() 
    {
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

    private void Update()
    {
        
    }

    public void Save() //Slot1
    {

        string filePath = Application.persistentDataPath + "/" + dataFile;
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(filePath);
        bf.Serialize(file, pData);
        file.Close();

        Debug.Log("Saved");
        //Debug.Log(pData.cabelo + "cabeleira");
    }

     public void LoadS()
    {
        string filePath = Application.persistentDataPath + "/" + dataFile;
        BinaryFormatter bf = new BinaryFormatter();
        if(File.Exists(filePath))
        {
            FileStream file = File.Open(filePath, FileMode.Open);
            PData loaded = (PData)bf.Deserialize(file);
            pData = loaded;
            file.Close();

            Debug.Log("Loaded");
        }
    }
}
[System.Serializable]
public class PData
{
    public int cabelo;
    public int cabeloC;
    public int pele;
    public int camisa;
    public int calca;
    public int tenis;

    public bool isCabeloCSave;

    public PData(SaveLoad saveLoad)
    {
        cabelo = 1;
        cabeloC = 0;
        pele = 0;
        camisa = 0;
        calca = 0;
        tenis = 0;

        isCabeloCSave = false;
    }
}

