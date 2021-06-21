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

    /// ATRIBUTO INTELIGENCIA USO:
    public int inteligencia;


    //BAR
    public int maxMana = 30;
    public int currentMana;
    public ManaBAr manaBar;

    // Start is called before the first frame update
    void Start()
    {
        maxMana = 30;
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
        //manaAcess = mana;
        //mana = manaAcess;
        //manaMostrar = manaAcess;
        //checkAcess = AnimationsC.nroPulosAcess;
        /*if(AnimationsC.segundoPulo == true)
        {
            mana = 0;
        }*/


    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Mana") == true)
        {
            //TEXT
            mana += 5 + (inteligencia * 2) ;
            if(mana > 30)
            {
                mana = 30;
            }
            //BAR
            //currentMana += 1;
            //manaBar.SetHealth(currentMana);
            manaBar.SetHealth(mana);
            //TakeMana(1);

            //Destroy(col.gameObject);
        }

        if(col.CompareTag("Cogumelo") == true && mana >= 1)
        {
            mana -= 10;
            if(mana < 0)
            {
                mana = 0;
            }
        }
    }

    void TakeMana(int colect)
    {
        currentMana += colect;

        manaBar.SetHealth(currentMana);
    }

}
