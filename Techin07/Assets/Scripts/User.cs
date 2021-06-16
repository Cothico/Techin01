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
    public string userName;

    public User()
    {
        userForLevel = XPManager.forLevel;
        userForXp = XPManager.forXp;
        userIntLevel = XPManager.intLevel;
        userIntXp = XPManager.intXp;
        userCarLevel = XPManager.carLevel;
        userCarXp = XPManager.carXp;
        userHabLevel = XPManager.habLevel;
        userHabXp = XPManager.habXp;
        userName = XPManager.playerName;
        //Só é possível pegar os dados em tempo real de uma classe sem monobehaviour ou static a partir de outra classe;
    }
}
