using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    Skins cabeloSkin, cabeloCSkin, peleSkin, camisaSkin, calcaSkin, tenisSkin;
    //public GameObject cabeloObj, cabeloCObj, peleObj, camisaObj, calcaObj, tenisObj;
    //CabeloProb cabeloProb;

    public int cabelo, cabeloC, pele, camisa, calca, tenis;
    //public bool isCabeloC;
    CabeloProb cabeloProb;

    // Start is called before the first frame update
    private void Awake()
    {
        cabeloSkin = GameObject.Find("CabeloObj").GetComponent<Skins>();
        cabeloCSkin = GameObject.Find("CabeloCObj").GetComponent<Skins>();
        peleSkin = GameObject.Find("PeleObj").GetComponent<Skins>();
        camisaSkin = GameObject.Find("CamisaObj").GetComponent<Skins>();
        calcaSkin = GameObject.Find("CalcaObj").GetComponent<Skins>();
        tenisSkin = GameObject.Find("TenisObj").GetComponent<Skins>();
        cabeloProb = FindObjectOfType<CabeloProb>();

        StartCoroutine(TavaNoStart());

        //cabeloProb = FindObjectOfType<CabeloProb>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            cabeloSkin.SkinsToSaveLoad();
            cabeloCSkin.SkinsToSaveLoad();
            peleSkin.SkinsToSaveLoad();
            camisaSkin.SkinsToSaveLoad();
            calcaSkin.SkinsToSaveLoad();
            tenisSkin.SkinsToSaveLoad();
            PlayerSave();
            Debug.Log("saved");

        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            PlayerLoad();
            //Debug.Log("loaded");

        }
    }

    public IEnumerator TavaNoStart()
    {
        yield return new WaitForSeconds(0.1f);
        PlayerLoad();
        UpdateSkins();
        
    }

    public void PlayerSave()
    {
        
        SaveSkinLoad.instance.pData.cabelo = cabelo;
        SaveSkinLoad.instance.pData.cabeloC = cabeloC;
        SaveSkinLoad.instance.pData.pele = pele;
        SaveSkinLoad.instance.pData.camisa = camisa;
        SaveSkinLoad.instance.pData.calca = calca;
        SaveSkinLoad.instance.pData.tenis = tenis;
        SaveSkinLoad.instance.pData.isCabeloCSave = cabeloProb.isCabeloC;
        SaveSkinLoad.instance.Save();
        Debug.Log(SaveSkinLoad.instance.pData.cabelo);
    }
    public void PlayerLoad()
    {
        //This loads in PData
        SaveSkinLoad.instance.LoadS();
        cabelo = SaveSkinLoad.instance.pData.cabelo;
        cabeloSkin.quantCamisa = SaveSkinLoad.instance.pData.cabelo;
        cabeloC = SaveSkinLoad.instance.pData.cabeloC;
        cabeloCSkin.quantCamisa = SaveSkinLoad.instance.pData.cabeloC;
        pele = SaveSkinLoad.instance.pData.pele;
        peleSkin.quantCamisa = SaveSkinLoad.instance.pData.pele;
        camisa = SaveSkinLoad.instance.pData.camisa;
        camisaSkin.quantCamisa = SaveSkinLoad.instance.pData.camisa;
        calca = SaveSkinLoad.instance.pData.calca;
        calcaSkin.quantCamisa = SaveSkinLoad.instance.pData.calca;
        tenis = SaveSkinLoad.instance.pData.tenis;
        tenisSkin.quantCamisa = SaveSkinLoad.instance.pData.tenis;
        cabeloProb.isCabeloC = SaveSkinLoad.instance.pData.isCabeloCSave;
        
    }

    public void UpdateSkins()
    {
        if(cabeloProb.isCabeloC == false)
        {
            cabeloSkin.NotIsCabeloC();
            if (cabelo == 0 || cabelo == 3)
            {
                cabeloSkin.quantCamisa = 0;
                cabeloSkin.isRuivo();
                 
            }
            if (cabelo == 1)
            {
                cabeloSkin.quantCamisa = 1;
                cabeloSkin.isLoiro();

            }
            if (cabelo == 2)
            {
                cabeloSkin.quantCamisa = 2;
                cabeloSkin.isPreto();

            }
                  
        }
        else{
            cabeloSkin.NotIsCabelo();
            if (cabeloC == 0 || cabeloC == 3)
            {
                cabeloCSkin.quantCamisa = 0;
                cabeloCSkin.isRuivoC();
                
            }
            if (cabeloC == 1)
            {
                cabeloCSkin.quantCamisa = 1;
                cabeloCSkin.isLoiroC();
                
            }
            if (cabeloC == 2)
            {
                cabeloCSkin.quantCamisa = 2;
                cabeloCSkin.isPretoC();
                
            }
            
        }
        if(pele == 0 || pele == 3)
        {
            peleSkin.quantCamisa = 0;
            peleSkin.IsPeleBranca();
        }
        if(pele == 1)
        {
            peleSkin.quantCamisa = 1;
            peleSkin.IsPeleNegra();
        }
        if(pele == 2)
        {
            peleSkin.quantCamisa = 2;
            peleSkin.IsPeleParda();
        }
        if(camisa == 0 || camisa == 3)
        {
            camisaSkin.quantCamisa = 0;
            camisaSkin.IsCamisaVermelha();
        }
        if(camisa == 1)
        {
            camisaSkin.quantCamisa = 1;
            camisaSkin.IsCamisaAzul();
        }
        if(camisa == 2)
        {
            camisaSkin.quantCamisa = 2;
            camisaSkin.IsCamisaVerde();
        }
        if(calca == 0 || calca == 3)
        {
            calcaSkin.quantCamisa = 0;
            calcaSkin.IsCalcaPreta();
        }
        if(calca == 1)
        {
            calcaSkin.quantCamisa = 1;
            calcaSkin.IsCalcaAzul();
        }
        if(calca == 2)
        {
            calcaSkin.quantCamisa = 2;
            calcaSkin.IsCalcaCaqui();
        }
        if(tenis == 0 || tenis == 3)
        {
            tenisSkin.quantCamisa = 0;
            tenisSkin.IsTenisPreto();
        }
        if(tenis == 1)
        {
            tenisSkin.quantCamisa = 1;
            tenisSkin.IsTenisCaqui();
        }
        if(tenis == 2)
        {
            tenisSkin.quantCamisa = 2;
            tenisSkin.IsTenisMarom();
        }
    }
}
