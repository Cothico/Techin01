using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    public GameObject /*5*/mainScreen, reponsavelScreen, criancaScreen, optionsScreen, /*0*/inicioScreen, /*1*/tutorial01, /*3*/loginScreen, /*4*/signScreen, /*2*/tutorial02, /*6*/menuAdmin;
    public bool firstTime = true;
    XPManager xPM;
    BlocoTarefas blocoTarefas;
    public InputField inputPassWord;
    public string password;
    User user = new User();
    //public bool isOptions = false;

    private void Awake() {
        xPM = GameObject.Find("portadorDoScript").GetComponent<XPManager>();
        blocoTarefas = FindObjectOfType<BlocoTarefas>();
    }

    void Start()
    {
        if(firstTime)
        {
            inicioScreen.SetActive(true);
            tutorial01.SetActive(false);
            tutorial02.SetActive(false);
            loginScreen.SetActive(false);
            signScreen.SetActive(false);
            mainScreen.SetActive(false);
            reponsavelScreen.SetActive(false);
            criancaScreen.SetActive(false);
            optionsScreen.SetActive(false);
            menuAdmin.SetActive(false);
        }
        else
        {
            inicioScreen.SetActive(false);
            tutorial01.SetActive(false);
            tutorial02.SetActive(false);
            loginScreen.SetActive(false);
            signScreen.SetActive(false);
            mainScreen.SetActive(true);
            reponsavelScreen.SetActive(false);
            criancaScreen.SetActive(false);
            optionsScreen.SetActive(false);
            menuAdmin.SetActive(false);
        }
    }

    public void GoToTutorial01() //inicio, vai tuto1
    {
        inicioScreen.SetActive(false);
        tutorial01.SetActive(true);
        mainScreen.SetActive(false);
        reponsavelScreen.SetActive(false);
        criancaScreen.SetActive(false);
        optionsScreen.SetActive(false);
    }
    public void ReturnToInicio() //tuto1, vai inicio
    {
        if(firstTime)
        {
            inicioScreen.SetActive(true);
            tutorial01.SetActive(false);
            mainScreen.SetActive(false);
            reponsavelScreen.SetActive(false);
            criancaScreen.SetActive(false);
            optionsScreen.SetActive(false);
        }
        else //tuto1, vai opt
        {
            inicioScreen.SetActive(false);
            tutorial01.SetActive(false);
            mainScreen.SetActive(false);
            reponsavelScreen.SetActive(false);
            criancaScreen.SetActive(false);
            optionsScreen.SetActive(true);
        }
        
    }
    public void SkipTutorial01() //tuto1, vai tuto2
    {  
        inicioScreen.SetActive(false);
        tutorial01.SetActive(false);
        tutorial02.SetActive(true);
        loginScreen.SetActive(false);
        mainScreen.SetActive(false);
        reponsavelScreen.SetActive(false);
        criancaScreen.SetActive(false);
        optionsScreen.SetActive(false);
    }

    public void SkipTutorial02() //tuto2, vai login
    {
        if(firstTime)
        {
            inicioScreen.SetActive(false);
            tutorial01.SetActive(false);
            tutorial02.SetActive(false);
            loginScreen.SetActive(true);
            signScreen.SetActive(false);
            mainScreen.SetActive(false);
            reponsavelScreen.SetActive(false);
            criancaScreen.SetActive(false);
            optionsScreen.SetActive(false);
        }
        else //tuto2, vai opt
        {
            inicioScreen.SetActive(false);
            tutorial01.SetActive(false);
            tutorial02.SetActive(false);
            loginScreen.SetActive(false);
            signScreen.SetActive(false);
            mainScreen.SetActive(false);
            reponsavelScreen.SetActive(false);
            criancaScreen.SetActive(false);
            optionsScreen.SetActive(true);  
        }
    }

    public void BackTutorial02() //login, vai tuto2
    {
        if(firstTime)
        {
            inicioScreen.SetActive(false);
            tutorial01.SetActive(false);
            tutorial02.SetActive(true);
            loginScreen.SetActive(false);
            signScreen.SetActive(false);
            mainScreen.SetActive(false);
            reponsavelScreen.SetActive(false);
            criancaScreen.SetActive(false);
            optionsScreen.SetActive(false);
        }
        else
        {
            inicioScreen.SetActive(false);
            tutorial01.SetActive(false);
            tutorial02.SetActive(false);
            loginScreen.SetActive(false);
            signScreen.SetActive(false);
            mainScreen.SetActive(false);
            reponsavelScreen.SetActive(false);
            criancaScreen.SetActive(false);
            optionsScreen.SetActive(true);
        }
    }

    public void GoToSign()
    {
        inicioScreen.SetActive(false);
        tutorial01.SetActive(false);
        tutorial02.SetActive(false);
        loginScreen.SetActive(false);
        signScreen.SetActive(true);
        mainScreen.SetActive(false);
        reponsavelScreen.SetActive(false);
        criancaScreen.SetActive(false);
        optionsScreen.SetActive(false);
    }

    public void BackToMenu()
    {
        loginScreen.SetActive(false);
        mainScreen.SetActive(true);
        reponsavelScreen.SetActive(false);
        criancaScreen.SetActive(false);
        optionsScreen.SetActive(false);
        firstTime = false;
    }

    public void GoToResponsavelScreen()
    {
        mainScreen.SetActive(false);
        reponsavelScreen.SetActive(true);
        //criancaScreen.SetActive(true);
        optionsScreen.SetActive(false);
    }

    public void OpenMenuAdmin()
    {
        if(inputPassWord.text == password)
        {
            inputPassWord.text = "";
            reponsavelScreen.SetActive(false);
            menuAdmin.SetActive(true);
            blocoTarefas.UpdateTasks();
        }
    }
    public void GoToCriancaScreen()
    {
        /*mainScreen.SetActive(false);
        reponsavelScreen.SetActive(true);
        criancaScreen.SetActive(true);
        optionsScreen.SetActive(false);*/
        SceneManager.LoadScene("Sc");
    }
    public void GoToOptions()
    {
        mainScreen.SetActive(false);
        reponsavelScreen.SetActive(false);
        criancaScreen.SetActive(false);
        optionsScreen.SetActive(true);
        //isOptions = true;
    }

    public void GoToLogin() //opt, vai login
    {
        inicioScreen.SetActive(false);
        tutorial01.SetActive(false);
        tutorial02.SetActive(false);
        loginScreen.SetActive(true);
        signScreen.SetActive(false);
        mainScreen.SetActive(false);
        reponsavelScreen.SetActive(false);
        criancaScreen.SetActive(false);
        optionsScreen.SetActive(false);
        if(xPM != null)
        {
            xPM.nameText.text = "";

            XPManager.forLevel = 0;
            XPManager.intLevel = 0;
            XPManager.carLevel = 0; //
            XPManager.habLevel = 0;
            XPManager.forXp = 0;
            XPManager.intXp = 0;
            XPManager.carXp = 0; //
            XPManager.habXp = 0;
            user.userForLevel = 0;
            user.userIntLevel = 0;
            user.userCarLevel = 0;
            user.userHabLevel = 0;
            user.userForXp = 0;
            user.userIntXp = 0;
            user.userCarXp = 0;
            user.userHabXp = 0; //
            //xPM.levelTex.text = "Level: " + user.userForLevel;
            xPM.UpdateLevel();
        }
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    /*public void InOptions()
    {
        isOptions = true;
    }

    public void OutOptions()
    {
        isOptions = false;
    }*/
}
