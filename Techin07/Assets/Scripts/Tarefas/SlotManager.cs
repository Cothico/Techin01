using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotManager : MonoBehaviour
{
    public GameObject thisSlot; //define qual o index do slot
    //GameObject blocoTarefasObj;
    BlocoTarefas blocoTarefas;
    SlotData slotData;
    public Image recompensaIcon;
    public Image tipoIcon;
    public Text iconDescription;
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
        if(blocoTarefas.isConfirming)
        {
            //UpdateSlotIcon();
            blocoTarefas.isConfirming = false;
        }
    }

    public void UpdateSlot()
    {
        slotData.currentSlot = blocoTarefas.slots.IndexOf(thisSlot);
         
    }

    /*public void UpdateSlotIcon() //ao entrar menu admin, ao confirmar tarefa
    {
        if(thisSlotIndex == 0)
        {
            recompensaIcon.sprite = blocoTarefas.recompensas[slotData.slot0reward];
            tipoIcon.sprite = blocoTarefas.tipos[slotData.slot0type];
            iconDescription.text = slotData.slot0description;
            Debug.Log("COCOCOCO  0");
        }
        if(thisSlotIndex == 1)
        {
            recompensaIcon.sprite = blocoTarefas.recompensas[slotData.slot1reward];
            tipoIcon.sprite = blocoTarefas.tipos[slotData.slot1type];
            iconDescription.text = slotData.slot1description;
            Debug.Log("COCOCOCO  1");
        }
        if(thisSlotIndex == 2)
        {
            recompensaIcon.sprite = blocoTarefas.recompensas[slotData.slot2reward];
            tipoIcon.sprite = blocoTarefas.tipos[slotData.slot2type];
            iconDescription.text = slotData.slot2description;
            Debug.Log("COCOCOCO  2");
        }
        if(thisSlotIndex == 3)
        {
            recompensaIcon.sprite = blocoTarefas.recompensas[slotData.slot3reward];
            tipoIcon.sprite = blocoTarefas.tipos[slotData.slot3type];
            iconDescription.text = slotData.slot3description;
            Debug.Log("COCOCOCO  3");
        }
        if(thisSlotIndex == 4)
        {
            recompensaIcon.sprite = blocoTarefas.recompensas[slotData.slot4reward];
            tipoIcon.sprite = blocoTarefas.tipos[slotData.slot4type];
            iconDescription.text = slotData.slot4description;
            Debug.Log("COCOCOCO  4");
        }
        if(thisSlotIndex == 5)
        {
            recompensaIcon.sprite = blocoTarefas.recompensas[slotData.slot5reward];
            tipoIcon.sprite = blocoTarefas.tipos[slotData.slot5type];
            iconDescription.text = slotData.slot5description;
            Debug.Log("COCOCOCO  5");
        }
        if(thisSlotIndex == 6)
        {
            recompensaIcon.sprite = blocoTarefas.recompensas[slotData.slot6reward];
            tipoIcon.sprite = blocoTarefas.tipos[slotData.slot6type];
            iconDescription.text = slotData.slot6description;
            Debug.Log("COCOCOCO  6");
        }
        if(thisSlotIndex == 7)
        {
            recompensaIcon.sprite = blocoTarefas.recompensas[slotData.slot7reward];
            tipoIcon.sprite = blocoTarefas.tipos[slotData.slot7type];
            iconDescription.text = slotData.slot7description;
            Debug.Log("COCOCOCO  7");
        }
    }*/

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
