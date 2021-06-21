using System;
using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//Problema = ao mudar de usuario se mantem o nivel do anterior //ainda existe 08/05
//possivel solução = reiniciar cena pra limpar os dados
public class XPManager : MonoBehaviour //Por enquanto 02/06 11:47 não estou usando
{
    //O que fazer: ao concluir tarefa: salva no json, depois leva do json pro fire base 05/06 19:00
    //Ao entrar logado: compara json e firebase o maior substitui o menor. 
    //public Text levelTex;
    //public InputField inputPassWord;
    //public TMP_InputField nameText;
    User user = new User();
    //PlayerXP playerXP;
    /*public static int forLevel;
    public static int intLevel;
    public static int carLevel;
    public static int habLevel;
    public static int forXp;
    public static int intXp;
    public static int carXp;
    public static int habXp;*/
    //public static string playerName; //Vai precisar ter inserção de nome de usuário
    public static int totalLevel;

    //public string password;
    public GameObject menuScreen;

    private void Awake() {
        //playerXP = FindObjectOfType<PlayerXP>();
    }
    void Start()
    {
        //RetrieveFromDatabase();
        //levelTex.text = "Level: " + playerLevel;
    }

    // Update is called once per frame

    public void OnSubmit()
    {
        //playerLevel = playerLevel + 1;
        user.userLevel = totalLevel;
        //levelTex.text = "Level: " + totalLevel;
        Debug.Log(totalLevel + "player lvl sub");
        Debug.Log(user.userLevel + "user lvl sub");
        PostOnDatabase();
    }

    public void ConfirmUser()
    {
        //playerName = nameText.text;
        //Debug.Log(user.userLevel + "user lvl confirm");
        PlayerXP.levelFor = user.userForLevel;
        PlayerXP.levelInt = user.userIntLevel;
        PlayerXP.levelCar = user.userCarLevel;
        PlayerXP.levelHab = user.userHabLevel;
        PlayerXP.xpFor = user.userForXp;
        PlayerXP.xpInt = user.userIntXp;
        PlayerXP.xpCar = user.userCarXp;
        PlayerXP.xpHab = user.userHabXp;
    }

    public void OnGetData() //Entrar cria
    {
        //playerName = nameText.text; //n sei se isso é importante
        RetrieveFromDatabase();
    }

    public void UpdateLevel()
    {
        //playerLevel = user.userLevel;
        //forLevel = user.userForLevel;
        PlayerXP.levelFor = user.userForLevel;
        PlayerXP.levelInt = user.userIntLevel;
        PlayerXP.levelCar = user.userCarLevel;
        PlayerXP.levelHab = user.userHabLevel;
        PlayerXP.xpFor = user.userForXp;
        PlayerXP.xpInt = user.userIntXp;
        PlayerXP.xpCar = user.userCarXp;
        PlayerXP.xpHab = user.userHabXp;
        //levelTex.text = "Level: " + forLevel;
        Debug.Log(user.userLevel+ "user lvl updt");
    }

    public void UpdateStatusInParent()
    {
        //referencias de texto e tostring
    }

    public void UpdateStatusInChildren()
    {
        //referencias de texto e tostring
    }

    public void TotalLevel()
    {
        totalLevel = user.userForLevel + user.userIntLevel + user.userCarLevel + user.userHabLevel;
        //levelTex.text = "Level: " + forLevel;
    }
    
    public void PostOnDatabase()
    {
        User user = new User();
        RestClient.Put("https://techin01-91221-default-rtdb.firebaseio.com/"/*+ playerName*/ + ".json", user);
    }

    public void RetrieveFromDatabase()
    {
        RestClient.Get<User>("https://techin01-91221-default-rtdb.firebaseio.com/"/*+ playerName*/ + ".json").Then(response =>
        {
            user = response;
            UpdateLevel();
            //Debug.Log(user.userLevel);
            //Debug.Log(user.userName);
        });
    }

    public void OnEnableMenu() 
    {
        //playerName = nameText.text;
        RetrieveFromDatabase();
        //Debug.Log("user for xp "+user.userForXp);
    }
}
