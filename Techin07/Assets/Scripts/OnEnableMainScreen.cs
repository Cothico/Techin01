using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnableMainScreen : MonoBehaviour
{
    XPManager xPM;
    Menu menu;

    private void Start() {
        xPM = GameObject.Find("portadorDoScript").GetComponent<XPManager>();
        menu = GameObject.Find("portadorDoScript").GetComponent<Menu>();
    }
    private void OnEnable() 
    {
        if(xPM != null)
        {
            xPM.OnEnableMenu();
        }
        /*if(menu != null)
        {
            menu.firstTime = false;
            //Debug.Log(menu.firstTime);
        }*/
    }

    private void OnDisable() 
    {
        if(xPM != null)
        {
            xPM.OnEnableMenu();
        }
        /*if(menu != null)
        {
            menu.firstTime = false;
            //Debug.Log(menu.firstTime);
        }*/
    }
}
