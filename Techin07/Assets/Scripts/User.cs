using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class User
{
    public int userForLevel;
    public int userIntLevel;
    public int userCarLevel;
    public int userHabLevel;
    public int userForXp;
    public int userIntXp;
    public int userCarXp;
    public int userHabXp;
    public int userLevel;
    //public string userName;

    public User()
    {
        userForLevel = PlayerXP.levelFor;
        userForXp = PlayerXP.xpFor;
        userIntLevel = PlayerXP.levelInt;
        userIntXp = PlayerXP.xpInt;
        userCarLevel = PlayerXP.levelCar;
        userCarXp = PlayerXP.xpCar;
        userHabLevel = PlayerXP.levelHab;
        userHabXp = PlayerXP.xpHab;
        userLevel = XPManager.totalLevel;
        //userName = XPManager.playerName;
        //Só é possível pegar os dados em tempo real de uma classe sem monobehaviour ou static a partir de outra classe;
    }
}
