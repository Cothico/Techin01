using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carisma : MonoBehaviour
{

    Check check;

    //public Color color = Color.white;

    //SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        //sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        check = FindObjectOfType<Check>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("CheckCarisma"))
        {            
            RandomCarisma();
        }
    }


    void RandomCarisma()
    {
        //random = Random.Range(0, 3);

        if (check.verRandom < 4)
        {
            GetComponent<BoxCollider2D>().enabled = true;
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            Debug.Log("Box True");
            //return;
        }
        else
        {
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.5f);
            
            Debug.Log("Box false");
        }
    }

}
