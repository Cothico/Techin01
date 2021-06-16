using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CriancaManager : MonoBehaviour
{
    void Start()
    {
        
    }

    public void BackToMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

}
