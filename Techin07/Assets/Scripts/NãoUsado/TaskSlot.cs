using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskSlot : MonoBehaviour
{
    //public Image icon;
    CreateTask ct;

    public void AddTask(CreateTask newTabela)
    {
        ct = newTabela;

        //icon.sprite = ct.icon;
        //icon.enabled = true;
    }

    public void ClearSlot()
    {
        ct = null;

        //icon.sprite = null;
        //icon.enabled = false;
    }
}
