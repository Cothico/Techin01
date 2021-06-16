using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColectGens : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_Object;

    public AudioSource somGensColect;
    //public TextMeshPro scoreTxt;   
    public static int scoreAcess;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        //m_Object.text = 
        //TextMesh mText = gameObject.GetComponent<TextMesh>();
        //somGensColect = SomActive.somAcess;
        somGensColect = GetComponent<AudioSource>();
        somGensColect.enabled = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_Object.text = score.ToString();
        scoreAcess = score;
        //scoreTxt.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Moeda") == true)
        {
            somGensColect.enabled = true;
            score = score + 1;
            Destroy(col.gameObject);
        }
    }
}
