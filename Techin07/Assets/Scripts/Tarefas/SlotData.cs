using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotData : MonoBehaviour //define qual o slot atual selecionado //onde deleta
{   //int slot0, slot1, slot2, slot3;
    public int currentSlot;
    BlocoTarefas blocoTarefas;
    public string descriptionInEditor;
    public int typeInEditor = 0;
    public int rewardInEditor = 0;
    public int activeTasks; //isso não esta sendo usado. Só no save

    //
    public int slot0type,slot1type, slot2type, slot3type, slot4type, slot5type, slot6type, slot7type;
    public int slot0reward,slot1reward, slot2reward, slot3reward, slot4reward, slot5reward, slot6reward, slot7reward;
    public string slot0description,slot1description, slot2description, slot3description, slot4description, slot5description, slot6description, slot7description;
    //

    void Start()
    {
        blocoTarefas = FindObjectOfType<BlocoTarefas>();
    }

    public void UpdateTasks()
    {
        
    }
    public void DeleteTask() //30/05 19:29 Fazer lance de passar dados ao excluir, que aquele bug que previ acontece mesmo
    {
        DeletingInQueue();
        
        //IsDeleting();
        
        //Debug.Log(blocoTarefas.tarefasAtivas +" on delete");
    }

    void IsDeleting() // isso não é mais útil, substituir pelo deletinginqueue
    {
        if(currentSlot == 0)
        {
            slot0type = 0;
            slot0reward = 0;
            slot0description = "";
        }
        if(currentSlot == 1)
        {
            slot1type = 0;
            slot1reward = 0;
            slot1description = "";
        }
        if(currentSlot == 2)
        {
            slot2type = 0;
            slot2reward = 0;
            slot2description = "";
        }
        if(currentSlot == 3)
        {
            slot3type = 3;
            slot3reward = 3;
            slot3description = "";
        }
        if(currentSlot == 4)
        {
            slot4type = 0;
            slot4reward = 0;
            slot4description = "";
        }
        if(currentSlot == 5)
        {
            slot5type = 0;
            slot5reward = 0;
            slot5description = "";
        }
        if(currentSlot == 6)
        {
            slot6type = 0;
            slot6reward = 0;
            slot6description = "";
        }
        if(currentSlot == 7)
        {
            slot7type = 0;
            slot7reward = 0;
            slot7description = "";
        }
    }

    void DeletingInQueue() //esta errado. Como deve ser: dentificar quantos slots devem ser concertados (num - curSlot > curSlot = curSlot + 1> curSlot + 1 = curSlot + 2 > slot(num) = 0). 
    { //Um problema acontece ao deletar o 1 ou o 2
        Debug.Log("entrou no metodo");
        int num = blocoTarefas.tarefasAtivas;
        int slotNum = currentSlot;
        Debug.Log(num);
        while(num >= currentSlot + 1)
        {
            Debug.Log("inicio do while");
            if(blocoTarefas.tarefasAtivas == 8)
            {
                if(slotNum == 7)
                {
                    slot7type = 0;
            slot7reward = 0;
            slot7description = "";
                }
                if(slotNum == 6)
                {
                    slot6type = slot7type;
            slot6reward = slot7reward;
            slot6description = slot7description;
                }
                if(slotNum == 5)
                {
                    slot5type = slot6type;
            slot5reward = slot6reward;
            slot5description = slot6description;
                }
                if(slotNum == 4)
                {
                    slot4type = slot5type;
            slot4reward = slot5reward;
            slot4description = slot5description;
                }
                if(slotNum == 3)
                {
                    slot3type = slot4type;
            slot3reward = slot4reward;
            slot3description = slot4description;
                }
                if(slotNum == 2)
                {
                    slot2type = slot3type;
            slot2reward = slot3reward;
            slot2description = slot3description;
                }
                if(slotNum == 1)
                {
                    slot1type = slot2type;
            slot1reward = slot2reward;
            slot1description = slot2description;
                }
                if(slotNum == 0)
                {
                    slot0type = slot1type;
            slot0reward = slot1reward;
            slot0description = slot1description;
                }
            }
            if(blocoTarefas.tarefasAtivas == 7)
            {
                if(slotNum == 6)
                {
                    slot6type = 0;
            slot6reward = 0;
            slot6description = "";
                }
                if(slotNum == 5)
                {
                    slot5type = slot6type;
            slot5reward = slot6reward;
            slot5description = slot6description;
                }
                if(slotNum == 4)
                {
                    slot4type = slot5type;
            slot4reward = slot5reward;
            slot4description = slot5description;
                }
                if(slotNum == 3)
                {
                    slot3type = slot4type;
            slot3reward = slot4reward;
            slot3description = slot4description;
                }
                if(slotNum == 2)
                {
                    slot2type = slot3type;
            slot2reward = slot3reward;
            slot2description = slot3description;
                }
                if(slotNum == 1)
                {
                    slot1type = slot2type;
            slot1reward = slot2reward;
            slot1description = slot2description;
                }
                if(slotNum == 0)
                {
                    slot0type = slot1type;
            slot0reward = slot1reward;
            slot0description = slot1description;
                }
            }
            if(blocoTarefas.tarefasAtivas == 6)
            {
                if(slotNum == 5)
                {
                    slot5type = 0;
            slot5reward = 0;
            slot5description = "";
                }
                if(slotNum == 4)
                {
                    slot4type = slot5type;
            slot4reward = slot5reward;
            slot4description = slot5description;
                }
                if(slotNum == 3)
                {
                    slot3type = slot4type;
            slot3reward = slot4reward;
            slot3description = slot4description;
                }
                if(slotNum == 2)
                {
                    slot2type = slot3type;
            slot2reward = slot3reward;
            slot2description = slot3description;
                }
                if(slotNum == 1)
                {
                    slot1type = slot0type;
            slot1reward = slot0reward;
            slot1description = slot0description;
                }
                if(slotNum == 0)
                {
                    slot0type = slot1type;
            slot0reward = slot1reward;
            slot0description = slot1description;
                }
            }
            if(blocoTarefas.tarefasAtivas == 5)
            {
                if(slotNum == 4)
                {
                    slot4type = 0;
            slot4reward = 0;
            slot4description = "";
                }
                if(slotNum == 3)
                {
                    slot3type = slot4type;
            slot3reward = slot1reward;
            slot3description = slot1description;
                }
                if(slotNum == 2)
                {
                    slot2type = slot3type;
            slot2reward = slot3reward;
            slot2description = slot3description;
                }
                if(slotNum == 1)
                {
                    slot1type = slot2type;
            slot1reward = slot2reward;
            slot1description = slot2description;
                }
                if(slotNum == 0)
                {
                    slot0type = slot1type;
            slot0reward = slot1reward;
            slot0description = slot1description;
                }
            }
            if(blocoTarefas.tarefasAtivas == 4)
            {
                if(slotNum == 3)
                {
                    slot3type = 0;
            slot3reward = 0;
            slot3description = "";
                }
                if(slotNum == 2)
                {
                    slot2type = slot3type;
            slot2reward = slot3reward;
            slot2description = slot3description;
                }
                if(slotNum == 1)
                {
                    slot1type = slot2type;
            slot1reward = slot2reward;
            slot1description = slot2description;
                }
                if(slotNum == 0)
                {
                    slot0type = slot1type;
            slot0reward = slot1reward;
            slot0description = slot1description;
                }
            }
            if(blocoTarefas.tarefasAtivas == 3)
            {
                if(slotNum == 2)
                {
                    slot2type = 0;
            slot2reward = 0;
            slot2description = "";
                }
                if(slotNum == 1)
                {
                    slot1type = slot2type;
            slot1reward = slot2reward;
            slot1description = slot2description;
                }
                if(slotNum == 0)
                {
                    slot0type = slot1type;
            slot0reward = slot1reward;
            slot0description = slot1description;
                }
            }
            if(blocoTarefas.tarefasAtivas == 2)
            {
                if(slotNum == 1)
                {
                    slot1type = 0;
            slot1reward = 0;
            slot1description = "";
                }
                if(slotNum == 0)
                {
                    slot0type = slot1type;
            slot0reward = slot1reward;
            slot0description = slot1description;
                }
            }
            if(blocoTarefas.tarefasAtivas == 1)
            {
                if(slotNum == 0)
                {
                    slot0type = 0;
            slot0reward = 0;
            slot0description = "";
                }
            }
            num --;
            slotNum++;
            Debug.Log("dentro do while");
        }
        Debug.Log("fora do while");
        Destroy(blocoTarefas.slots[currentSlot]);
        blocoTarefas.slots.Remove(blocoTarefas.slots[currentSlot]);
        currentSlot = 0;
        blocoTarefas.CloseTaskEditor();
        blocoTarefas.tarefasAtivas = blocoTarefas.slots.Count;
        activeTasks = blocoTarefas.slots.Count;
        blocoTarefas.currentDescricao = "";
        SaveSystem.instance.SaveTasks();
    }

    /*public void Description()
    {
        blocoTarefas.slots[currentSlot]
    }*/
}
