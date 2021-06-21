using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpdateXPCustom : MonoBehaviour
{
    XPManager xPManager;
    PlayerXP playerXP;
    Moviment moviment;
    StaminaBar staminaBar;
    ManaC manaC;
    Check check;
    public bool isGame;
    public GameObject loading;
    User user = new User();
    // Start is called before the first frame update

    private void Awake() {
        xPManager = FindObjectOfType<XPManager>();
        playerXP = FindObjectOfType<PlayerXP>();
        xPManager.RetrieveFromDatabase();
    }
    void Start()
    {
        if(!isGame)
        {
            loading.SetActive(true);
            Debug.Log("é falso mesmo");
            StartCoroutine(UpdateLevels());
        }
        else{
            moviment = FindObjectOfType<Moviment>();
            staminaBar = FindObjectOfType<StaminaBar>();
            manaC = FindObjectOfType<ManaC>();
            check = FindObjectOfType<Check>();
            moviment.atr_Habilidade = PlayerXP.levelHab; 
            staminaBar.atributoForca = PlayerXP.levelFor;
            manaC.inteligencia = PlayerXP.levelInt;
            check.carisma = PlayerXP.levelCar;
        }
        
    }

    IEnumerator UpdateLevels()
    {
        yield return new WaitForSeconds(2f);
        loading.SetActive(false);
        PlayerXP.totalLevel = PlayerXP.levelFor + PlayerXP.levelHab + PlayerXP.levelInt + PlayerXP.levelCar;
        playerXP.ptot.text = PlayerXP.totalLevel.ToString();
        playerXP.pfor.text = PlayerXP.levelFor.ToString();
        playerXP.pint.text = PlayerXP.levelInt.ToString(); 
        playerXP.pcar.text = PlayerXP.levelCar.ToString(); 
        playerXP.phab.text = PlayerXP.levelHab.ToString(); 
        Debug.Log(user.userForLevel);
    }

    public void PlayGame01()
    {
        SceneManager.LoadScene("Cavalo");
    }
}
