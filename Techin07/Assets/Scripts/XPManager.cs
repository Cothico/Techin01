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
    public TMP_InputField nameText;
    User user = new User();

    public static int forLevel;
    public static int intLevel;
    public static int carLevel;
    public static int habLevel;
    public static int forXp;
    public static int intXp;
    public static int carXp;
    public static int habXp;
    public static string playerName; //Vai precisar ter inserção de nome de usuário

    //public string password;
    public GameObject menuScreen;

    // Start is called before the first frame update
    void Start()
    {
        //RetrieveFromDatabase();
        //levelTex.text = "Level: " + playerLevel;
    }

    // Update is called once per frame

    public void OnSubmit()
    {
        //if(inputPassWord.text == password)
        //{
            
            /*playerLevel = playerLevel + 1;
            user.userLevel = playerLevel;
            levelTex.text = "Level: " + playerLevel;
            Debug.Log(playerLevel + "player lvl sub");
            Debug.Log(user.userLevel + "user lvl sub");
            PostOnDatabase();*/
        //}
    }

    public void ConfirmUser()
    {
        playerName = nameText.text;
        //Debug.Log(user.userLevel + "user lvl confirm");
        forLevel = user.userForLevel;
        intLevel = user.userIntLevel;
        carLevel = user.userCarLevel;
        habLevel = user.userHabLevel;
        forXp = user.userForXp;
        intXp = user.userIntXp;
        carXp = user.userCarXp;
        habXp = user.userHabXp;
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
        forLevel = user.userForLevel;
        intLevel = user.userIntLevel;
        carLevel = user.userCarLevel;
        habLevel = user.userHabLevel;
        forXp = user.userForXp;
        intXp = user.userIntXp;
        carXp = user.userCarXp;
        habXp = user.userHabXp;
        //levelTex.text = "Level: " + forLevel;
        //Debug.Log(user.userLevel+ "user lvl updt");
    }
    
    private void PostOnDatabase()
    {
        User user = new User();
        RestClient.Put("https://techin01-91221-default-rtdb.firebaseio.com/"+ playerName + ".json", user);
    }

    private void RetrieveFromDatabase()
    {
        RestClient.Get<User>("https://techin01-91221-default-rtdb.firebaseio.com/"+ playerName + ".json").Then(response =>
        {
            user = response;
            UpdateLevel();
            //Debug.Log(user.userLevel);
            //Debug.Log(user.userName);
        });
    }

    public void OnEnableMenu() 
    {
        playerName = nameText.text;
        RetrieveFromDatabase();
        //Debug.Log("user for xp "+user.userForXp);
    }
}
