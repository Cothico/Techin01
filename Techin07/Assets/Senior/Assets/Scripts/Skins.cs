using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skins : MonoBehaviour
{
    //public SpriteRenderer bodyPart;
    public GameObject tipo01, tipo02, tipo03;
    public GameObject tipo04, tipo05, tipo06;
    public int quantCamisa = 0;

    public List<GameObject> cabelo, cabeloC, pele, camisa, calca, tenis;
    public bool cabeloBoo, cabeloCBoo, peleBoo, camisaBoo, calcaBoo, tenisBoo;

    public bool isCabeloC;

    SalvarSkinPlayer salvarSkinP;
    //Moviment moviment;
    SaveLoad saveLoad;
    CabeloProb cabeloProb;
    // Start is called before the first frame update
    //public List<Sprite> options = new List<Sprite>();
    private void Awake()
    {
        salvarSkinP = FindObjectOfType<SalvarSkinPlayer>();
        saveLoad = FindObjectOfType<SaveLoad>();
        cabeloProb = FindObjectOfType<CabeloProb>();
        
        if (cabeloBoo && cabelo.Count == 0)
        {
            
        cabelo.Add(tipo01);
        cabelo.Add(tipo02);
        cabelo.Add(tipo03);
            
        }
        if (cabeloCBoo && cabeloC.Count == 0)
        {
            //if (cabeloProb.isCabeloC == true)
            //{
        cabeloC.Add(tipo01);
        cabeloC.Add(tipo02);
        cabeloC.Add(tipo03);
            //}
        }
        if (peleBoo && pele.Count == 0)
        {
        pele.Add(tipo01);
        pele.Add(tipo02);
        pele.Add(tipo03);
        }
        if (camisaBoo && camisa.Count == 0)
        {
        camisa.Add(tipo01);
        camisa.Add(tipo02);
        camisa.Add(tipo03);
        }
        if(calcaBoo && calca.Count == 0)
        {
            calca.Add(tipo01);
            calca.Add(tipo02);
            calca.Add(tipo03);
        }
        if(tenisBoo && tenis.Count == 0)
        {
            tenis.Add(tipo01);
            tenis.Add(tipo02);
            tenis.Add(tipo03);
        }
        StartCoroutine(TavaNoStart());
        
    }

    private void Start()
    {
        
        //Debug.Log(quantCamisa);
        //saveLoad.UpdateSkins();
    }

    private void Update()
    {
        
    }
    IEnumerator TavaNoStart()
    {
        yield return new WaitForSeconds(0.1f);
        if (cabeloBoo)
        {
            if(cabeloProb.isCabeloC == false)
            {
                quantCamisa = SaveSkinLoad.instance.pData.cabelo;
            }
        }
        if (cabeloCBoo)
        {
            if (cabeloProb.isCabeloC == true)
            {
                quantCamisa = SaveSkinLoad.instance.pData.cabeloC;
            }

        }
        if (peleBoo)
        {
            quantCamisa = SaveSkinLoad.instance.pData.pele;
        }
        if (camisaBoo)
        {
            quantCamisa = SaveSkinLoad.instance.pData.camisa;
        }
        if (calcaBoo)
        {
            quantCamisa = SaveSkinLoad.instance.pData.calca;
        }
        if (tenisBoo)
        {
            quantCamisa = SaveSkinLoad.instance.pData.tenis;
        }
    }
    //CABELO
    public void isRuivo()
    {
        Debug.Log("is ruivo");
        cabelo[0].SetActive(false);
        cabelo[1].SetActive(false);
        cabelo[2].SetActive(true);
    }
    public void isLoiro()
    {
        cabelo[0].SetActive(true);
        cabelo[1].SetActive(false);
        cabelo[2].SetActive(false);
    }
    public void isPreto()
    {
        Debug.Log("isPReto");
        cabelo[0].SetActive(false);
        cabelo[1].SetActive(true);
        cabelo[2].SetActive(false);
    }
    //CABELO CUMPRIDO
    public void isRuivoC()
    {
        cabeloC[0].SetActive(false);
        cabeloC[1].SetActive(false);
        cabeloC[2].SetActive(true);
    }
    public void isLoiroC()
    {
        cabeloC[0].SetActive(true);
        cabeloC[1].SetActive(false);
        cabeloC[2].SetActive(false);
    }
    public void isPretoC()
    {
        cabeloC[0].SetActive(false);
        cabeloC[1].SetActive(true);
        cabeloC[2].SetActive(false);
    }
    public void NotIsCabelo()
    {
        //Debug.Log("not is cabelo da cabeça");
        tipo01.SetActive(false);
        tipo02.SetActive(false);
        tipo03.SetActive(false);
    }
    public void NotIsCabeloC()
    {
        Debug.Log("not is cabelo do cu");
        tipo01.SetActive(false);
        tipo02.SetActive(false);
        tipo03.SetActive(false);
    }
    public void IsPeleNegra()
    {
        pele[0].SetActive(true);
        pele[1].SetActive(false);
        pele[2].SetActive(false);
    }
     public void IsPeleParda()
    {
        pele[0].SetActive(false);
        pele[1].SetActive(true);
        pele[2].SetActive(false);
    }
     public void IsPeleBranca()
    {
        pele[0].SetActive(false);
        pele[1].SetActive(false);
        pele[2].SetActive(true);
    }
    public void IsCamisaAzul()
    {
        camisa[0].SetActive(true);
        camisa[1].SetActive(false);
        camisa[2].SetActive(false);
    }
    public void IsCamisaVerde()
    {
        camisa[0].SetActive(false);
        camisa[1].SetActive(true);
        camisa[2].SetActive(false);
    }
    public void IsCamisaVermelha()
    {
        camisa[0].SetActive(false);
        camisa[1].SetActive(false);
        camisa[2].SetActive(true);
    }
    public void IsCalcaAzul()
    {
        calca[0].SetActive(true);
        calca[1].SetActive(false);
        calca[2].SetActive(false);
    }
    public void IsCalcaCaqui()
    {
        calca[0].SetActive(false);
        calca[1].SetActive(true);
        calca[2].SetActive(false);
    }
    public void IsCalcaPreta()
    {
        calca[0].SetActive(false);
        calca[1].SetActive(false);
        calca[2].SetActive(true);
    }
    public void IsTenisCaqui()
    {
        tenis[0].SetActive(true);
        tenis[1].SetActive(false);
        tenis[2].SetActive(false);
    }
    public void IsTenisMarom()
    {
        tenis[0].SetActive(false);
        tenis[1].SetActive(true);
        tenis[2].SetActive(false);
    }
    public void IsTenisPreto()
    {
        tenis[0].SetActive(false);
        tenis[1].SetActive(false);
        tenis[2].SetActive(true);
    }


    public void Botao()
    {
        quantCamisa++;
        if (quantCamisa == 1)
        {
            tipo01.SetActive(true);
            tipo02.SetActive(false);
            tipo03.SetActive(false);
        }
        else if (quantCamisa == 2)
        {
            tipo01.SetActive(false);
            tipo02.SetActive(true);
            tipo03.SetActive(false);
        }
        else
        {
            tipo01.SetActive(false);
            tipo02.SetActive(false);
            tipo03.SetActive(true);
            quantCamisa = 0;
        }
    }

    public void BotaoCabelo()
    {
        tipo04.SetActive(false);
        tipo05.SetActive(false);
        tipo06.SetActive(false);

        quantCamisa++;
        if (quantCamisa == 1)
        {
            tipo01.SetActive(true);
            tipo02.SetActive(false);
            tipo03.SetActive(false);
        }
        else if (quantCamisa == 2)
        {
            tipo01.SetActive(false);
            tipo02.SetActive(true);
            tipo03.SetActive(false);
        }
        else
        {
            tipo01.SetActive(false);
            tipo02.SetActive(false);
            tipo03.SetActive(true);
            quantCamisa = 0;
        }
    }

    /*public void UpdateSkin()
    {
        if (quantCamisa == 1)
        {
            tipo01.SetActive(true);
            tipo02.SetActive(false);
            tipo03.SetActive(false);
        }
        else if (quantCamisa == 2)
        {
            tipo01.SetActive(false);
            tipo02.SetActive(true);
            tipo03.SetActive(false);
        }
        else
        {
            tipo01.SetActive(false);
            tipo02.SetActive(false);
            tipo03.SetActive(true);
            quantCamisa = 0;
        }
    }*/

    /*public void UpdateCabelo()
    {
        tipo04.SetActive(false);
        tipo05.SetActive(false);
        tipo06.SetActive(false);

        if (salvarSkinP.myPlayerS.cabelo == 1)
        {
            //Debug.Log("Cabelo1");
            tipo01.SetActive(true);
            tipo02.SetActive(false);
            tipo03.SetActive(false);
        }
        else if (salvarSkinP.myPlayerS.cabelo == 2)
        {
            //Debug.Log("Cabelo2");
            tipo01.SetActive(false);
            tipo02.SetActive(true);
            tipo03.SetActive(false);
        }
        else
        {
            //Debug.Log("Cabelo0");
            tipo01.SetActive(false);
            tipo02.SetActive(false);
            tipo03.SetActive(true);
        }

        //Debug.Log("Saiu Update");
    }*/

    public void SkinsToSaveLoad()
    {
        //isCabeloC = cabeloProb.isCabeloC;
        if (cabeloBoo)
        {
            if(cabeloProb.isCabeloC == false)
            {
                saveLoad.cabelo = quantCamisa;
                //Debug.Log( saveLoad.cabelo + "transportou para saveload");
            }
        }
        if (cabeloCBoo)
        {
            if (cabeloProb.isCabeloC == true)
            {
                saveLoad.cabeloC = quantCamisa;
            }

        }
        if (peleBoo)
        {
            saveLoad.pele = quantCamisa;
        }
        if (camisaBoo)
        {
            saveLoad.camisa = quantCamisa;
        }
        if (calcaBoo)
        {
            saveLoad.calca = quantCamisa;
        }
        if (tenisBoo)
        {
            saveLoad.tenis = quantCamisa;
        }
    }
    /*public void UpdateCabeloC()
    {
        tipo04.SetActive(false);
        tipo05.SetActive(false);
        tipo06.SetActive(false);

        if (salvarSkinP.cabeloCSkinQuant == 1)
        {
            tipo01.SetActive(true);
            tipo02.SetActive(false);
            tipo03.SetActive(false);
        }
        else if (salvarSkinP.cabeloCSkinQuant == 2)
        {
            tipo01.SetActive(false);
            tipo02.SetActive(true);
            tipo03.SetActive(false);
        }
        else
        {
            tipo01.SetActive(false);
            tipo02.SetActive(false);
            tipo03.SetActive(true);
        }
    }

    public void UpdateCamisa()
    {       

        if (salvarSkinP.camisaSkinQuant == 1)
        {
            tipo01.SetActive(true);
            tipo02.SetActive(false);
            tipo03.SetActive(false);
        }
        else if (salvarSkinP.camisaSkinQuant == 2)
        {
            tipo01.SetActive(false);
            tipo02.SetActive(true);
            tipo03.SetActive(false);
        }
        else
        {
            tipo01.SetActive(false);
            tipo02.SetActive(false);
            tipo03.SetActive(true);
        }
    }*/

}
