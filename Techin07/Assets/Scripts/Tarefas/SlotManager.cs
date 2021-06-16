using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotManager : MonoBehaviour
{
    public GameObject thisSlot; //define qual o index do slot
    //GameObject blocoTarefasObj;
    BlocoTarefas blocoTarefas;
    SlotData slotData;
    public string myDescription;
    public int myType = 0;
    public int myReward = 0;
    public int myActiveTasls = 0;

    int thisSlotIndex;

    // Start is called before the first frame update
    void Start()
    {
        blocoTarefas = GameObject.Find("portadorDoScript").GetComponent<BlocoTarefas>();
        //blocoTarefas = blocoTarefasObj.GetComponent<BlocoTarefas>();
        slotData = FindObjectOfType<SlotData>();
    }

    // Update is called once per frame
    void Update()
    {
        thisSlotIndex = blocoTarefas.slots.IndexOf(thisSlot);
    }

    public void UpdateSlot()
    {
        slotData.currentSlot = thisSlotIndex;
         
    }

    public void OpenTaskEditor()
    {
        UpdateSlot();
        blocoTarefas.OpeningTaskEditor();
        //Debug.Log(thisSlotIndex+" On open editor");
    }

    //public 

    /*public void DeleteTask()
    {
        blocoTarefas.slots[thisSlotIndex].SetActive(false);
    }*/
}
