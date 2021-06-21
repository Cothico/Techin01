using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    int carismaStart;
    public int carisma;
    public int verRandom;

    // Start is called before the first frame update
    void Start()
    {
        carismaStart = 5;
        carismaStart += carisma;
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Inimigo"))
        {
            int random = Random.Range(0, carismaStart);
            verRandom = random;
        }   
    }
}
