using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpdateXPCustom : MonoBehaviour
{
    XPManager xPManager;
    PlayerXP playerXP;
    User user = new User();
    // Start is called before the first frame update

    private void Awake() {
        xPManager = FindObjectOfType<XPManager>();
        playerXP = FindObjectOfType<PlayerXP>();
        xPManager.RetrieveFromDatabase();
    }
    void Start()
    {
        StartCoroutine(UpdateLevels());
    }

    IEnumerator UpdateLevels()
    {
        yield return new WaitForSeconds(0.15f);
        PlayerXP.totalLevel = PlayerXP.levelFor + PlayerXP.levelHab + PlayerXP.levelInt + PlayerXP.levelCar;
        playerXP.ptot.text = PlayerXP.totalLevel.ToString();
        playerXP.pfor.text = PlayerXP.levelFor.ToString();
        playerXP.pint.text = PlayerXP.levelInt.ToString(); 
        playerXP.pcar.text = PlayerXP.levelCar.ToString(); 
        playerXP.phab.text = PlayerXP.levelHab.ToString(); 
    }

    public void PlayGame01()
    {
        SceneManager.LoadScene("Cavalo");
    }
}
