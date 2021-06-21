using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerXP : MonoBehaviour
{
    BlocoTarefas blocoTarefas;
    XPManager xPManager;
    int baseXpToUp = 100;
    //int xpToUp;
    public static int levelFor;
    public static int xpFor;
    public static int levelInt;
    public static int xpInt;
    public static int levelCar;
    public static int xpCar;
    public static int levelHab;
    public static int xpHab;
    public static int totalLevel;
    [Header ("papisScreen")]
    public Text phab;
    public Text pint;
    public Text pfor;
    public Text pcar;
    public Text ptot;


    int levelMultiplier = 21; //xpToUp = level * levelMultiplier + baseXpToUp

    void Start()
    {
        blocoTarefas = FindObjectOfType<BlocoTarefas>();
        xPManager = FindObjectOfType<XPManager>();
    }

    public void AddXP(int amount, int type)
    {
        if(type == 1)
        {
            xpFor += amount;
            int xpToUp = levelFor * levelMultiplier + baseXpToUp;
            if(xpFor >= xpToUp)
            {
                levelFor++;
                xpFor -= xpToUp;
                xPManager.OnSubmit();
                pfor.text = levelFor.ToString();
                StartCoroutine(CallUpdateXp());
            }
        }
        if(type == 2)
        {
            xpInt += amount;
            int xpToUp = levelInt * levelMultiplier + baseXpToUp;
            if(xpInt >= xpToUp)
            {
                levelInt++;
                xpInt -= xpToUp;
                xPManager.OnSubmit();
                pint.text = levelInt.ToString();
                StartCoroutine(CallUpdateXp());
            }
        }
        if(type == 3)
        {
            xpCar += amount;
            int xpToUp = levelCar * levelMultiplier + baseXpToUp;
            if(xpCar >= xpToUp)
            {
                levelCar++;
                xpCar -= xpToUp;
                xPManager.OnSubmit();
                pcar.text = levelCar.ToString();
                StartCoroutine(CallUpdateXp());
            }
        }
        if(type == 4)
        {
            xpHab += amount;
            int xpToUp = levelHab * levelMultiplier + baseXpToUp;
            if(xpHab >= xpToUp)
            {
                levelHab++;
                xpHab -= xpToUp;
                xPManager.OnSubmit();
                phab.text = levelHab.ToString();
                StartCoroutine(CallUpdateXp());
            }
        }
    }

    IEnumerator CallUpdateXp()
    {
        yield return new WaitForSeconds(0.5f);
        totalLevel = levelFor + levelHab + levelInt + levelCar;
        ptot.text = totalLevel.ToString(); 
        UpdateXp();
    }

    void UpdateXp()
    {

 
            int xpToUp = levelFor * levelMultiplier + baseXpToUp;
            if(xpFor >= xpToUp)
            {
                levelFor++;
                xpFor -= xpToUp;
                xPManager.OnSubmit();
                pfor.text = levelFor.ToString();
                StartCoroutine(CallUpdateXp());
            }


            int xpToUp2 = levelInt * levelMultiplier + baseXpToUp;
            if(xpInt >= xpToUp)
            {
                levelInt++;
                xpInt -= xpToUp;
                xPManager.OnSubmit();
                pint.text = levelInt.ToString();
                StartCoroutine(CallUpdateXp());
            }



            int xpToUp3 = levelCar * levelMultiplier + baseXpToUp;
            if(xpCar >= xpToUp)
            {
                levelCar++;
                xpCar -= xpToUp;
                xPManager.OnSubmit();
                pcar.text = levelCar.ToString();
                StartCoroutine(CallUpdateXp());
            }


            int xpToUp4 = levelHab * levelMultiplier + baseXpToUp;
            if(xpHab >= xpToUp)
            {
                levelHab++;
                xpHab -= xpToUp;
                xPManager.OnSubmit();
                phab.text = levelHab.ToString();
                StartCoroutine(CallUpdateXp());
            }
            
    }

    public void ConcluirTarefa() //save
    {
        if(blocoTarefas.currentRecompensa != 0 || blocoTarefas.currentTipo != 0)
        {
            AddXP(blocoTarefas.xpAmount, blocoTarefas.currentTipo);
            /*XPManager.forLevel = levelFor;
            XPManager.intLevel = levelInt;
            XPManager.carLevel = levelCar;
            XPManager.habLevel = levelHab;
            XPManager.forXp = xpFor;
            XPManager.intXp = xpInt;
            XPManager.carXp = xpCar;
            XPManager.habXp = xpHab;*/
            //blocoTarefas.SavePlayer();
            /*User user = new User();
            Debug.Log(user.userForXp);
            Debug.Log(xpInt + "Int XP");
            Debug.Log(levelInt + "Int level");*/
            //xPManager.Po(); aki <<--- **
        }
        
    }
}
