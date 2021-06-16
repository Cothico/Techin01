using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreSave : MonoBehaviour
{
    public static int scoreMaxAcess;

    public int scoreAtualDoNivel;
    public int scoreMaximoSalvo;
    string nomedaCena;

    // Start is called before the first frame update
    void Start()
    {
        scoreAtualDoNivel = 0;
        scoreMaximoSalvo = 0;
        nomedaCena = SceneManager.GetActiveScene().name;
        if(PlayerPrefs.HasKey(nomedaCena + "score"))
        {
            scoreMaximoSalvo = PlayerPrefs.GetInt(nomedaCena + "score");
        }

        //DELETA VALOR SALVO NA CHAVE:
        //PlayerPrefs.DeleteKey(nomedaCena + "score");
    }

    // Update is called once per frame
    void Update()
    {
        scoreAtualDoNivel = ColectGens.scoreAcess;
        //coreAtualDoNivel = (int) transform.position.x;
        scoreMaxAcess = scoreMaximoSalvo;
        //fazer checar quando morrer
        ChecarScore();
    }

    void ChecarScore()
    {
        if(scoreAtualDoNivel > scoreMaximoSalvo)
        {
            scoreMaximoSalvo = scoreAtualDoNivel;
            PlayerPrefs.SetInt(nomedaCena + "score", scoreMaximoSalvo);
            scoreMaxAcess = scoreMaximoSalvo;
        }
    }
}
