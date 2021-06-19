using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> grounds = new List<GameObject>();
    public GameObject startBlock;
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
        GetBorderNew(startBlock);
        LevelGeneratorF();

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
            grounds[i].transform.position = new Vector3(currentBorder.position.x + halfBlockSize + gapX, currentBorder.position.y + gapY, 0f);
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
        Debug.Log("novaBorda");
        Transform[] borders = block.gameObject.GetComponentsInChildren<Transform>();

        foreach (Transform t in borders)
        {
            /*if (t.tag == "Border")
            {
                currentBorder = t;
            }*/

            if (t.CompareTag ("Border") == true)
            {
                Debug.Log("tagBorda");
                //Debug.Log("novaBorda");
                currentBorder = t;
            }
        }

    }

    public void PlaceGround(GameObject groundBlock)
    {
        //halfBlockSize = GetComponent<BoxCollider2D>().bounds.extents.x;

        Debug.Log("colocar bloco");
        gapY = Random.Range(-intervalY, intervalY);
        groundBlock.transform.position = new Vector3(currentBorder.position.x + halfBlockSize + gapX, currentBorder.position.y + gapY, 0f);
        //PlaceCoin(groundBlock);
        BoxCollider2D[] boxes = groundBlock.GetComponents/*sInChildren*/<BoxCollider2D>();
        boxes[0].enabled = true;
        Debug.Log("encontrar box colider");
    }

    public void PlaceCoin(GameObject groundBlock)
    {
        Coin coin = groundBlock.GetComponentInChildren<Coin>();

        if (Random.Range(0.0f, 1.0f) > 0.4f)
        {
            coin.gameObject.GetComponent<CircleCollider2D>().enabled = true;
            coin.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            coin.gameObject.GetComponent<CircleCollider2D>().enabled = false;
            coin.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
