using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColectMana : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI m_Object;

    private int mana;

    //BARRA MANA
    public Image manaBar;
    public float myMana;

    private float currentMana;
    private float calculateMana;
    
    void Start()
    {
        mana = 0;
        currentMana = myMana;
    }   

    // Update is called once per frame
    void Update()
    {
        m_Object.text = mana.ToString();

        //BARRA MANA
        calculateMana = currentMana / myMana;
        manaBar.fillAmount = Mathf.MoveTowards(manaBar.fillAmount, calculateMana, Time.deltaTime);
        m_Object.text = "" + (int)currentMana;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Mana") == true)
        {
            mana = mana + 1;
            currentMana += mana;
            Destroy(col.gameObject);
        }
    }
}
