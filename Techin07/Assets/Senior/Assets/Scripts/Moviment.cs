using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Moviment : MonoBehaviour
{
    /*public GameObject cabeloObj, cabeloCObj, peleObj, camisaObj, calcaObj, tenisObj;
    Skins cabeloSkin, cabeloCSkin, peleSkin, camisaSkin, calcaSkin, tenisSkin;

    CabeloProb cabeloProb;
    

    ///
    SalvarSkinPlayer acessScripSave;*/
    //public bool acessScripSave;

    //Skins cabeloSkin, cabeloCSkin, peleSkin, camisaSkin, calcaSkin, tenisSkin;
    //public GameObject cabeloObj, cabeloCObj, peleObj, camisaObj, calcaObj, tenisObj;
    //CabeloProb cabeloProb;


    //public int cabelo, cabeloC, pele, camisa, calca, tenis;

    /// <summary>
    /// 
    /// </summary>
    /// 

    public float aceleraHabilidade;
    public float lamaHabilidade;

    public int atr_Habilidade;


    public float Speed;
    public float JumpForce;

    private Rigidbody2D rig;
    public GameObject cavalo;

    public Animator animator;


    // Start is called before the first frame update
    private void Awake()
    {
        /*cabeloSkin = cabeloObj.gameObject.GetComponent<Skins>();
        cabeloCSkin = cabeloCObj.gameObject.GetComponent<Skins>();
        peleSkin = peleObj.gameObject.GetComponent<Skins>();
        camisaSkin = camisaObj.gameObject.GetComponent<Skins>();
        calcaSkin = calcaObj.gameObject.GetComponent<Skins>();
        tenisSkin = tenisObj.gameObject.GetComponent<Skins>();

        cabeloProb = FindObjectOfType<CabeloProb>();*/
    }
    void Start()
    {

        //acessScripSave.GetComponent<SalvarSkinPlayer>().loadFromFile();
        //LoadPlayer();
        Speed = 2;
        rig = GetComponent<Rigidbody2D>();
        //PlayerLoad();

       /* //CABELO CURTO
        if(cabelo == 0)
        {
            cabeloSkin.isRuivo();
        }
        if (cabelo == 1)
        {
            cabeloSkin.isLoiro();
        }
        if (cabelo == 2)
        {
            cabeloSkin.isPreto();
        }

        //CABELO CUMPRIDO
        if (cabeloC == 0)
        {
            cabeloCSkin.isRuivoC();
        }
        if (cabeloC == 1)
        {
            cabeloCSkin.isLoiroC();
        }
        if (cabeloC == 2)
        {
            cabeloCSkin.isPretoC();
        }*/


    }

    // Update is called once per frame
    void Update()
    {
        Move();
        //Jump(); ([transferido para scripts: AnimationsC)]       
    }

    void Move()
    {
        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        Vector3 movement = new Vector3(2f, 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PointAce") == true)
        {
            float flotando = atr_Habilidade;
            aceleraHabilidade = flotando / 5f;
            Speed = 2.2f + aceleraHabilidade;


            //AtrazoCavalo();

        }
        
        if (collision.CompareTag("FollowPoint") == true)
        {
            //Debug.Log("Estabilizou");
            Speed = 2;
        }

        if(collision.CompareTag("PointMor") == true)
        {
            //Debug.Log("GAME OVER");
        }

        if(collision.CompareTag("ObjDesacelera") == true)
        {
            //Debug.Log("Desacelerou");

            //DESACELERAR MAIS LENTO (HABILIDADE)
            /*float habilidade = atr_Habilidade;
            lamaHabilidade = habilidade / 5f;
            Speed = 1 - lamaHabilidade;*/

            Speed = 1;
        }
        /*else
        {
            float flotando = atr_Habilidade;
            aceleraHabilidade = flotando / 5f;
            Speed = 2.2f + aceleraHabilidade;
        }*/
    }

    IEnumerable AtrazoCavalo()
    {
        yield return new WaitForSeconds(0.1f);
        Speed = 3;
    }

    /*public void PlayerLoad()
    {
        SaveSkinLoad.instance.LoadS();//This loads in PData
        cabelo = SaveSkinLoad.instance.pData.cabelo;
        cabeloC = SaveSkinLoad.instance.pData.cabeloC;
        pele = SaveSkinLoad.instance.pData.pele;
        camisa = SaveSkinLoad.instance.pData.camisa;
        calca = SaveSkinLoad.instance.pData.calca;
        tenis = SaveSkinLoad.instance.pData.tenis;
    }*/

    /*public void LoadPlayer()
    {
        //Debug.Log("Entrou Load");

        //SalvarSkinPlayer.instance.loadFromFile();
      

        if (cabeloProb.isCabeloC == false)
        {
            cabeloSkin.UpdateCabelo();
            //Debug.Log("isCabelo");
        }
        else
        {
            cabeloCSkin.UpdateCabelo();
            //Debug.Log("isCabeloC");
        }

        peleSkin.UpdateSkin();
        //camisaSkin.UpdateCamisa();
        calcaSkin.UpdateSkin();
        tenisSkin.UpdateSkin();

        //Debug.Log("Saiu Load");

        Debug.Log(cabeloSkin.quantCamisa + " cabelo");
        //SalvarSkinPlayer.instance.
    }*/
}
