using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointsText;
    [SerializeField] TextMeshProUGUI record;

    //ColectGens colectGens;
    ScoreSave scoreSave;
    ColectGens colectG;
    public void Setup(int score)
    {
        //colectGens = GetComponent<ColectGens>();
        colectG = GetComponent<ColectGens>();
        scoreSave = GetComponent<ScoreSave>();

        gameObject.SetActive(true);
        pointsText.text = "Record: " + ScoreSave.scoreMaxAcess.ToString();
        record.text = "Pontuação: " + ColectGens.scoreAcess.ToString();
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
