using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    Transform moeda, tronco, lama, mana, pedra, cogumelo, orq;

    GameObject moeda00, moeda01, moeda02, tronco00, tronco01, lama00, lama01, mana00, mana01, mana02;

    public bool checkActive;
    /// <summary>
    /// 
    /// </summary>

    public List<GameObject> moedas = new List<GameObject>();

    public List<GameObject> grounds = new List<GameObject>();
    public GameObject startBlock;
    public Transform pointProY;
    Transform currentBorder;
    public float gapX;
    float gapY;
    public float intervalY;
    float halfBlockSize;

    //GameObject coin;


    // Start is called before the first frame update
    void Start()
    {
        GetBlocSize();
        //GetBorderNew(startBlock);
        GetBorderNew(startBlock);
        LevelGeneratorF();
        pointProY.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LevelGeneratorF()
    {

        for (int i = 0; i < grounds.Count; i++)
        {
            gapY = Random.Range(-intervalY, intervalY);

            grounds[i].transform.position = new Vector3(currentBorder.position.x + halfBlockSize + gapX, pointProY.position.y + gapY, 0f);
            GetBorderNew(grounds[i]);
            //Debug.Log(currentBorder.position.x);
        }

    }

    void GetBlocSize()
    {
        halfBlockSize = startBlock.GetComponent<BoxCollider2D>().bounds.extents.x;
        //Debug.Log(halfBlockSize);
    }

    public void GetBorderNew(GameObject block)
    {
        //halfBlockSize = GetComponent<BoxCollider2D>().bounds.extents.x;

        Transform[] borders = block.gameObject.GetComponentsInChildren<Transform>();

        foreach (Transform t in borders)
        {
            /*if (t.tag == "Border")
            {
                currentBorder = t;
            }*/

            if (t.CompareTag ("Border") == true)
            {
                currentBorder = t;
            }
        }

    }

    public void PlaceGround(GameObject groundBlock)
    {
        //halfBlockSize = GetComponent<BoxCollider2D>().bounds.extents.x;

        gapY = Random.Range(-intervalY, intervalY);
        //groundBlock.transform.position = new Vector3(currentBorder.position.x + halfBlockSize + gapX, currentBorder.position.y + gapY, 0f);
        groundBlock.transform.position = new Vector3(currentBorder.position.x + halfBlockSize + gapX, pointProY.position.y + gapY, 0f);
        //PlaceCoin(groundBlock);
        RandomItens(groundBlock);
        //RandomMoeda(groundBlock);
        BoxCollider2D[] boxes = groundBlock.GetComponents/*sInChildren*/<BoxCollider2D>();
        boxes[0].enabled = true;
    }


    public void RandomItens(GameObject groundBlock)
    {
        moeda = groundBlock.gameObject.transform.GetChild(3);
        tronco = groundBlock.gameObject.transform.GetChild(4);
        lama = groundBlock.gameObject.transform.GetChild(5);
        mana = groundBlock.gameObject.transform.GetChild(6);
        pedra = groundBlock.gameObject.transform.GetChild(7);
        cogumelo = groundBlock.gameObject.transform.GetChild(8);
        orq = groundBlock.gameObject.transform.GetChild(9);

        float randon = Random.Range(0.0f, 1.0f);
        float randonOrq = Random.Range(0.0f, 1.0f);

        RandomMoeda(groundBlock);

        if(randonOrq < 0.3)
        {
            orq.gameObject.SetActive(true);
            checkActive = true;
        }
        else
        {
            orq.gameObject.SetActive(false);
            checkActive = false;
        }


        if (randon < 0.2f)
        {
            moeda.gameObject.SetActive(true);
            tronco.gameObject.SetActive(false);
            lama.gameObject.SetActive(true);
            mana.gameObject.SetActive(true);
            pedra.gameObject.SetActive(false);
            cogumelo.gameObject.SetActive(false);
        }
        else if (randon >= 0.2f && randon < 0.4)
        {
            moeda.gameObject.SetActive(true);
            tronco.gameObject.SetActive(true);
            lama.gameObject.SetActive(false);
            mana.gameObject.SetActive(false);
            pedra.gameObject.SetActive(false);
            cogumelo.gameObject.SetActive(true);
        }
        else if (randon >= 0.4f && randon < 0.6)
        {
            moeda.gameObject.SetActive(false);
            tronco.gameObject.SetActive(true);
            lama.gameObject.SetActive(true);
            mana.gameObject.SetActive(true);
            pedra.gameObject.SetActive(false);
            cogumelo.gameObject.SetActive(false);
        }
        else if (randon >= 0.6f && randon < 0.8)
        {
            moeda.gameObject.SetActive(true);
            tronco.gameObject.SetActive(false);
            lama.gameObject.SetActive(false);
            mana.gameObject.SetActive(false);
            pedra.gameObject.SetActive(true);
            cogumelo.gameObject.SetActive(false);
        }
        else
        {
            moeda.gameObject.SetActive(false);
            tronco.gameObject.SetActive(false);
            lama.gameObject.SetActive(false);
            mana.gameObject.SetActive(false);
            pedra.gameObject.SetActive(false);
            cogumelo.gameObject.SetActive(false);
        }



    }

    public void RandomMoeda(GameObject groundBlock)
    {
        /*moeda = groundBlock.gameObject.transform.GetChild(3);
        tronco = groundBlock.gameObject.transform.GetChild(4);
        lama = groundBlock.gameObject.transform.GetChild(5);
        mana = groundBlock.gameObject.transform.GetChild(6);
        pedra = groundBlock.gameObject.transform.GetChild(7);*/


        moeda00 = groundBlock.gameObject.transform.GetChild(3).GetChild(0).gameObject;
        moeda01 = groundBlock.gameObject.transform.GetChild(3).GetChild(1).gameObject;
        moeda02 = groundBlock.gameObject.transform.GetChild(3).GetChild(2).gameObject;

        tronco00 = groundBlock.gameObject.transform.GetChild(4).GetChild(0).gameObject;
        tronco01 = groundBlock.gameObject.transform.GetChild(4).GetChild(1).gameObject;

        lama00 = groundBlock.gameObject.transform.GetChild(5).GetChild(0).gameObject;
        lama01 = groundBlock.gameObject.transform.GetChild(5).GetChild(1).gameObject;

        mana00 = groundBlock.gameObject.transform.GetChild(6).GetChild(0).gameObject;
        mana01 = groundBlock.gameObject.transform.GetChild(6).GetChild(1).gameObject;
        mana02 = groundBlock.gameObject.transform.GetChild(6).GetChild(2).gameObject;


        int randonMoeda = Random.Range(0, 2);
        int randonTronco = Random.Range(0, 1);
        int randonLama = Random.Range(0, 1);
        int randonMana = Random.Range(0, 2);

        //RANDOM MOEDA
        if (randonMoeda == 0)
        {
            moeda00.SetActive(true);
            moeda01.SetActive(false);
            moeda02.SetActive(false);
        }
        if (randonMoeda == 1)
        {
            moeda00.SetActive(false);
            moeda01.SetActive(true);
            moeda02.SetActive(false);
        }
        if (randonMoeda == 2)
        {
            moeda00.SetActive(false);
            moeda01.SetActive(false);
            moeda02.SetActive(true);
        }

        //RANDOM TRONCO
        if (randonTronco == 0)
        {
            tronco00.SetActive(true);
            tronco01.SetActive(false);
        }
        if (randonTronco == 1)
        {
            tronco00.SetActive(false);
            tronco01.SetActive(true);
        }

        //RANDOM LAMA
        if (randonLama == 0)
        {
            lama00.SetActive(true);
            lama01.SetActive(false);
        }
        if (randonLama == 1)
        {
            lama00.SetActive(false);
            lama01.SetActive(true);
        }

        //RANDOM MANA
        if (randonMana == 0)
        {
            mana00.SetActive(true);
            mana01.SetActive(false);
            mana02.SetActive(false);
        }
        if (randonMana == 1)
        {
            mana00.SetActive(false);
            mana01.SetActive(true);
            mana02.SetActive(false);
        }
        if (randonMana == 2)
        {
            mana00.SetActive(false);
            mana01.SetActive(false);
            mana02.SetActive(true);
        }

    }
}
