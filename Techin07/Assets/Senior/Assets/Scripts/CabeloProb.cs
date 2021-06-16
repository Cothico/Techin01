using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabeloProb : MonoBehaviour
{
    public bool isCabeloC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CralhoCabelo()
    {
        isCabeloC = true;
    }

    public void PoraCabelo()
    {
        isCabeloC = false;
    }
}
