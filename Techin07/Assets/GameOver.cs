using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointsText;
    public void Setup(int score)
    {       
        gameObject.SetActive(true);
        pointsText.text = "Pontuação: " + ScoreSave.scoreMaxAcess.ToString(); 
        //intsText.text = score.ToString() + " PONTUAÇÂO";
    }

    // Start is called before the first frame update
    public void RestartButton()
    {
        SceneManager.LoadScene("Cavalo");
    }

    // Update is called once per frame
    public void ExitButton()
    {
        SceneManager.LoadScene("SkinSelect");
    }
}
