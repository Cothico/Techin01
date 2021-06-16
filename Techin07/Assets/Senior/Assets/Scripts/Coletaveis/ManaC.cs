using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManaC : MonoBehaviour
{
    public int checkAcess;

    //TEXT
    [SerializeField] TextMeshProUGUI m_Object;
    public static int manaAcess;
    public int mana;
    //public int manaMostrar;

    //BAR
    public int maxMana = 3;
    public int currentMana;
    public ManaBAr manaBar;

    // Start is called before the first frame update
    void Start()
    {
        //TEXT
        mana = 0;

        //BAR
        currentMana = maxMana;
        manaBar.SetMaxHealth(maxMana);
        //currentMana = 0;        
        //manaBar.SetHealth(0);

        //SALTO DUPLO

    }

    // Update is called once per frame
    void Update()
    {
        m_Object.text = mana.ToString();
        manaBar.SetHealth(mana);
        manaAcess = mana;
        //mana = manaAcess;
        //manaMostrar = manaAcess;
        //checkAcess = AnimationsC.nroPulosAcess;
        if(AnimationsC.segundoPulo == true)
        {
            mana = 0;
        }


    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Mana") == true)
        {
            //TEXT
            mana = mana + 1;

            //BAR
            //currentMana += 1;
            //manaBar.SetHealth(currentMana);
            manaBar.SetHealth(mana);
            //TakeMana(1);
            Destroy(col.gameObject);
        }

        if(col.CompareTag("Cogumelo") == true && mana >= 1)
        {
            mana = mana - 1;
        }
    }

    void TakeMana(int colect)
    {
        currentMana += colect;

        manaBar.SetHealth(currentMana);
    }

}
