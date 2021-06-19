using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXP : MonoBehaviour
{
    BlocoTarefas blocoTarefas;
    int baseXpToUp = 100;
    //int xpToUp;
    int levelFor;
    int xpFor;
    int levelInt;
    int xpInt;
    int levelCar;
    int xpCar;
    int levelHab;
    int xpHab;
    int levelMultiplier = 21; //xpToUp = level * levelMultiplier + baseXpToUp

    void Start()
    {
        blocoTarefas = FindObjectOfType<BlocoTarefas>();
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
            }
        }
    }

    public void ConcluirTarefa() //save
    {
        if(blocoTarefas.currentRecompensa != 0 || blocoTarefas.currentTipo != 0)
        {
            AddXP(blocoTarefas.xpAmount, blocoTarefas.currentTipo);
            XPManager.forLevel = levelFor;
            XPManager.intLevel = levelInt;
            XPManager.carLevel = levelCar;
            XPManager.habLevel = levelHab;
            XPManager.forXp = xpFor;
            XPManager.intXp = xpInt;
            XPManager.carXp = xpCar;
            XPManager.habXp = xpHab;
            User user = new User();
            Debug.Log(user.userForXp);
            //Debug.Log(xpFor + "Força XP");
            //Debug.Log(levelFor + "Força level");
        }
        
    }
}
