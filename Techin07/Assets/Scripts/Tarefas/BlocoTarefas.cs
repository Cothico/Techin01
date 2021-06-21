using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BlocoTarefas : MonoBehaviour //Meu //interações no menu de tarefas //Aqui se define os dados salvos para cada bloco
{ // >> Falta atualizar os icones e carregar os dados ao clicar
    public GameObject painelTipo, painelRecompensa, editorTabela, botaoRecompensa, botaoTipo/*, blocoIcon*/;
    public GameObject prefabTarefa;
    Image recompensa;
    Image tipo;
    
    SlotData slotData;

    //
    public int tarefasAtivas;
    int taskToDelete;
    public List<GameObject> slots = new List<GameObject>();
    //

    public Sprite[] recompensas = new Sprite[5];
    public Sprite[] tipos = new Sprite[5];
    //int taskID;

    public InputField descricao;
    public GameObject[] tasks;
    public int currentRecompensa;
    public int xpAmount;
    public int currentTipo;
    public string currentDescricao;
    public bool isConfirming = false;
    


    private void Awake() {
        recompensa = botaoRecompensa.GetComponent<Image>();
        tipo = botaoTipo.GetComponent<Image>();
        slotData = FindObjectOfType<SlotData>();
    }
    void Start()
    {
        recompensa.sprite = recompensas[0];
        tipo.sprite = tipos[0];
        painelRecompensa.SetActive(false);
        painelTipo.SetActive(false);
        editorTabela.SetActive(false);
    }

    private void Update() {
        if(currentRecompensa == 1)
        {
            xpAmount = 15;
        }
        if(currentRecompensa == 2)
        {
            xpAmount = 50;
        }
        if(currentRecompensa == 3)
        {
            xpAmount = 100;
        }
        if(currentRecompensa == 4)
        {
            xpAmount = 300;
        }
        if(currentRecompensa == 0)
        {
            xpAmount = 0;
        }

        //if(tasks[] == 0)
        //{

        //}
        //tipo.sprite = tipos[slotData.typeInEditor];
        //recompensa.sprite = recompensas[slotData.rewardInEditor];
        //////descricao.text = 
        //slotData.descriptionInEditor
    }

    /*public void OpenTaskEditor()
    {
        editorTabela.SetActive(true);
    }
*/
    public void UpdateTaskData() //Problema atuar 30/05 18:64 - ao mudar dados de uma tarefa, os dados são exzibidos ao abrir qualquer outra tarefa. oq fazer > currntData se tornam padrão ao fechar e ao abrir abre o carregamento 
    {                              //problema atual 30/05 19:10 - dados funcionam da maneira correta, porém na primeira vez q abre uma task está com os dados errados, e se conserta na segunda
        if(slotData.currentSlot == 0)
        {
            currentTipo = slotData.slot0type;
            currentRecompensa = slotData.slot0reward;
            currentDescricao = slotData.slot0description;
        }
        if(slotData.currentSlot == 1)
        {
            currentTipo = slotData.slot1type;
            currentRecompensa = slotData.slot1reward;
            currentDescricao = slotData.slot1description;
        }
        if(slotData.currentSlot == 2)
        {
            currentTipo = slotData.slot2type;
            currentRecompensa = slotData.slot2reward;
            currentDescricao = slotData.slot2description;
        }
        if(slotData.currentSlot == 3)
        {
            currentTipo = slotData.slot3type;
            currentRecompensa = slotData.slot3reward;
            currentDescricao = slotData.slot3description;
        }
        if(slotData.currentSlot == 4)
        {
            currentTipo = slotData.slot4type;
            currentRecompensa = slotData.slot4reward;
            currentDescricao = slotData.slot4description;
        }
        if(slotData.currentSlot == 5)
        {
            currentTipo = slotData.slot5type;
            currentRecompensa = slotData.slot5reward;
            currentDescricao = slotData.slot5description;
        }
        if(slotData.currentSlot == 6)
        {
            currentTipo = slotData.slot6type;
            currentRecompensa = slotData.slot6reward;
            currentDescricao = slotData.slot6description;
        }
        if(slotData.currentSlot == 7)
        {
            currentTipo = slotData.slot7type;
            currentRecompensa = slotData.slot7reward;
            currentDescricao = slotData.slot7description;
        }
        descricao.text = currentDescricao;

        if(currentTipo == 1)
        {
            Tipo1();
        }
        if(currentTipo == 2)
        {
            Tipo2();
        }
        if(currentTipo == 3)
        {
            Tipo3();
        }
        if(currentTipo == 4)
        {
            Tipo4();
        }
        if(currentRecompensa == 1)
        {
            Recompensa1();
        }
        if(currentRecompensa == 2)
        {
            Recompensa2();
        }
        if(currentRecompensa == 3)
        {
            Recompensa3();
        }
        if(currentRecompensa == 4)
        {
            Recompensa4();
        }
        //currentTipo = 0; //Talvez tenha q tirar esses 3
        //currentRecompensa = 0;
        //currentDescricao = ""; 
    }

    public void CloseTaskEditor()
    {
        //currentTipo = 0;
        //currentRecompensa = 0;
        //currentDescricao = ""; 
        //tipo.sprite = tipos[slotData.typeInEditor];
        //recompensa.sprite = recompensas[slotData.rewardInEditor];
        editorTabela.SetActive(false);
        //UpdateTaskData();
    }

    public void CloseTaskEditorOnConfirm()
    {
        tipo.sprite = tipos[slotData.typeInEditor];
        recompensa.sprite = recompensas[slotData.rewardInEditor];
        editorTabela.SetActive(false);
    }

    public void OpeningTaskEditor() 
    {
        tipo.sprite = tipos[slotData.typeInEditor];
        recompensa.sprite = recompensas[slotData.rewardInEditor];
        
        UpdateTaskData();
        editorTabela.SetActive(true);
        //Debug.Log(slotData.currentSlot + "cur slot");
    }

    public void confirmTaskEdition() //save //Update dos icons está incluido
    {
        currentDescricao = descricao.text;
        if(slotData.currentSlot == 0)
        {
            slotData.slot0type = currentTipo;
            slotData.slot0reward = currentRecompensa;
            slotData.slot0description = currentDescricao;
        }
        if(slotData.currentSlot == 1)
        {
            slotData.slot1type = currentTipo;
            slotData.slot1reward = currentRecompensa;
            slotData.slot1description = currentDescricao;
        }
        if(slotData.currentSlot == 2)
        {
            slotData.slot2type = currentTipo;
            slotData.slot2reward = currentRecompensa;
            slotData.slot2description = currentDescricao;
        }
        if(slotData.currentSlot == 3)
        {
            slotData.slot3type = currentTipo;
            slotData.slot3reward = currentRecompensa;
            slotData.slot3description = currentDescricao;
        }
        if(slotData.currentSlot == 4)
        {
            slotData.slot4type = currentTipo;
            slotData.slot4reward = currentRecompensa;
            slotData.slot4description = currentDescricao;
        }
        if(slotData.currentSlot == 5)
        {
            slotData.slot5type = currentTipo;
            slotData.slot5reward = currentRecompensa;
            slotData.slot5description = currentDescricao;
        }
        if(slotData.currentSlot == 6)
        {
            slotData.slot6type = currentTipo;
            slotData.slot6reward = currentRecompensa;
            slotData.slot6description = currentDescricao;
        }
        if(slotData.currentSlot == 7)
        {
            slotData.slot7type = currentTipo;
            slotData.slot7reward = currentRecompensa;
            slotData.slot7description = currentDescricao;
        }
        UpdateTasksIcon();
        editorTabela.SetActive(false);
        SavePlayer();
        //descricao.text = "";
        //UpdateTaskData();
        //isConfirming = true;
        //Debug.Log(currentDescricao + currentRecompensa + currentTipo+ " current things");
        //UpdateTasks
    }

    public void UpdateTasksIcon()
    {
        if(tarefasAtivas >= 1)
        {
            SlotManager sm0 = slots[0].GetComponent<SlotManager>();
            sm0.tipoIcon.sprite = tipos[slotData.slot0type];
            sm0.recompensaIcon.sprite = recompensas[slotData.slot0reward];
            sm0.iconDescription.text = slotData.slot0description;
        }
        if(tarefasAtivas >= 2)
        {
            SlotManager sm1 = slots[1].GetComponent<SlotManager>();
            sm1.tipoIcon.sprite = tipos[slotData.slot1type];
            sm1.recompensaIcon.sprite = recompensas[slotData.slot1reward];
            sm1.iconDescription.text = slotData.slot1description;
        }
        if(tarefasAtivas >= 3)
        {
            SlotManager sm2 = slots[2].GetComponent<SlotManager>();
            sm2.tipoIcon.sprite = tipos[slotData.slot2type];
            sm2.recompensaIcon.sprite = recompensas[slotData.slot2reward];
            sm2.iconDescription.text = slotData.slot2description;
        }
        if(tarefasAtivas >= 4)
        {
            SlotManager sm3 = slots[3].GetComponent<SlotManager>();
            sm3.tipoIcon.sprite = tipos[slotData.slot3type];
            sm3.recompensaIcon.sprite = recompensas[slotData.slot3reward];
            sm3.iconDescription.text = slotData.slot3description;
        }
        if(tarefasAtivas >= 5)
        {
            SlotManager sm4 = slots[4].GetComponent<SlotManager>();
            sm4.tipoIcon.sprite = tipos[slotData.slot4type];
            sm4.recompensaIcon.sprite = recompensas[slotData.slot4reward];
            sm4.iconDescription.text = slotData.slot4description;
        }
        if(tarefasAtivas >= 6)
        {
            SlotManager sm5 = slots[5].GetComponent<SlotManager>();
            sm5.tipoIcon.sprite = tipos[slotData.slot5type];
            sm5.recompensaIcon.sprite = recompensas[slotData.slot5reward];
            sm5.iconDescription.text = slotData.slot5description;
        }
        if(tarefasAtivas >= 7)
        {
            SlotManager sm6 = slots[6].GetComponent<SlotManager>();
            sm6.tipoIcon.sprite = tipos[slotData.slot6type];
            sm6.recompensaIcon.sprite = recompensas[slotData.slot6reward];
            sm6.iconDescription.text = slotData.slot6description;
        }
        if(tarefasAtivas >= 8)
        {
            SlotManager sm7 = slots[7].GetComponent<SlotManager>();
            sm7.tipoIcon.sprite = tipos[slotData.slot7type];
            sm7.recompensaIcon.sprite = recompensas[slotData.slot7reward];
            sm7.iconDescription.text = slotData.slot7description;
        }
    }

    public void OpenRewardPanel()
    {
        painelRecompensa.SetActive(true);
        painelTipo.SetActive(false);
    }

    public void OpenTypePanel()
    {
        painelRecompensa.SetActive(false);
        painelTipo.SetActive(true);
    }

//Recompensas //Aqui inserir entrada dos dados para ser salvo em cada bloco
    public void Recompensa1()
    {
        recompensa.sprite = recompensas[1];
        painelRecompensa.SetActive(false);
        currentRecompensa = 1;
    }
    public void Recompensa2()
    {
        recompensa.sprite = recompensas[2];
        painelRecompensa.SetActive(false);
        currentRecompensa = 2;
    }
    public void Recompensa3()
    {
        recompensa.sprite = recompensas[3];
        painelRecompensa.SetActive(false);
        currentRecompensa = 3;
    }
    public void Recompensa4()
    {
        recompensa.sprite = recompensas[4];
        painelRecompensa.SetActive(false);
        currentRecompensa = 4;
    }
//Tipos
    public void Tipo1()
    {
        tipo.sprite = tipos[1];
        painelTipo.SetActive(false);
        currentTipo = 1;
    }

    public void Tipo2()
    {
        tipo.sprite = tipos[2];
        painelTipo.SetActive(false);
        currentTipo = 2;
    }

    public void Tipo3()
    {
        tipo.sprite = tipos[3];
        painelTipo.SetActive(false);
        currentTipo = 3;
    }

    public void Tipo4()
    {
        tipo.sprite = tipos[4];
        painelTipo.SetActive(false);
        currentTipo = 4;
    }

    //// Creation
    public void CreateNewTask()
    {
        if(slots.Count < 8) //Precisa pegar as dimensoes do painel para ajustar o tamanho do bloco com referencia nele
        {
            GameObject newTask = GameObject.Instantiate(prefabTarefa, Vector3.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
            //var creating = Instantiate(prefabTarefa, GameObject.Find("slotsGroup").transform.position, GameObject.Find("slotsGroup").transform.rotation);
            newTask.transform.localScale = new Vector3(newTask.transform.localScale.x * 0.028f, newTask.transform.localScale.y * 0.028f, 0);
            newTask.transform.SetParent(GameObject.Find("slotsGroup").transform);
            //creating.transform.SetParent = GameObject.Find("slotsGroup").transform;
            slots.Add(newTask);
            //slots[tarefasAtivas].SetActive(true);
            tarefasAtivas = slots.Count;
            slotData.activeTasks = slots.Count;
            //Debug.Log(tarefasAtivas + "actives On Create");
            //Debug.Log(slotData.currentSlot + "cur slot");
        }  
    }

    public void CreateTaskOnLoad()
    {
        if(slots.Count < 8) //Precisa pegar as dimensoes do painel para ajustar o tamanho do bloco com referencia nele
        {
            GameObject newTask = GameObject.Instantiate(prefabTarefa, Vector3.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
            newTask.transform.localScale = new Vector3(newTask.transform.localScale.x * 0.028f, newTask.transform.localScale.y * 0.028f, 0);
            newTask.transform.SetParent(GameObject.Find("slotsGroup").transform);
            slots.Add(newTask);
        }  
    }
    
    public void UpdateTasks() //ao entrar no menu admin
    {
        Debug.Log("entrô");
        if(slotData.activeTasks == 0)
        {
            Debug.Log("é zero uai");
        }
        if(slotData.activeTasks == 1)
        {
            CreateTaskOnLoad();
        }
        if(slotData.activeTasks == 2)
        {
            CreateTaskOnLoad();
            CreateTaskOnLoad();
        }
        if(slotData.activeTasks == 3)
        {
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
        }
        if(slotData.activeTasks == 4)
        {
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
        }
        if(slotData.activeTasks == 5)
        {
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
        }
        if(slotData.activeTasks == 6)
        {
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
        }
        if(slotData.activeTasks == 7)
        {
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
        }
        if(slotData.activeTasks == 8)
        {
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
            CreateTaskOnLoad();
        }
        UpdateTasksIcon();
    }

    public void ClearTasks()// ao sair do menu admin
    {
        if(tarefasAtivas == 0)
        {

        }
        if(tarefasAtivas == 1)
        {
            slotData.slot0type = 0;
            slotData.slot1reward = 0;
            slotData.slot0description = "";
            Destroy(slots[0]);
        }
        if(tarefasAtivas == 2)
        {
            slotData.slot0type = 0;
            slotData.slot0reward = 0;
            slotData.slot0description = "";
            Destroy(slots[0]);
            slotData.slot1type = 0;
            slotData.slot1reward = 0;
            slotData.slot1description = "";
            Destroy(slots[1]);
        }
        if(tarefasAtivas == 3)
        {
            slotData.slot0type = 0;
            slotData.slot0reward = 0;
            slotData.slot0description = "";
            Destroy(slots[0]);
            slotData.slot1type = 0;
            slotData.slot1reward = 0;
            slotData.slot1description = "";
            Destroy(slots[1]);
            slotData.slot2type = 0;
            slotData.slot2reward = 0;
            slotData.slot2description = "";
            Destroy(slots[2]);
        }
        if(tarefasAtivas == 4)
        {
            slotData.slot0type = 0;
            slotData.slot0reward = 0;
            slotData.slot0description = "";
            Destroy(slots[0]);
            slotData.slot1type = 0;
            slotData.slot1reward = 0;
            slotData.slot1description = "";
            Destroy(slots[1]);
            slotData.slot2type = 0;
            slotData.slot2reward = 0;
            slotData.slot2description = "";
            Destroy(slots[2]);
            slotData.slot3type = 0;
            slotData.slot3reward = 0;
            slotData.slot3description = "";
            Destroy(slots[3]);
        }
        if(tarefasAtivas == 5)
        {
            slotData.slot0type = 0;
            slotData.slot0reward = 0;
            slotData.slot0description = "";
            Destroy(slots[0]);
            slotData.slot1type = 0;
            slotData.slot1reward = 0;
            slotData.slot1description = "";
            Destroy(slots[1]);
            slotData.slot2type = 0;
            slotData.slot2reward = 0;
            slotData.slot2description = "";
            Destroy(slots[2]);
            slotData.slot3type = 0;
            slotData.slot3reward = 0;
            slotData.slot3description = "";
            Destroy(slots[3]);
            slotData.slot4type = 0;
            slotData.slot4reward = 0;
            slotData.slot4description = "";
            Destroy(slots[4]);
        }
        if(tarefasAtivas == 6)
        {
            slotData.slot0type = 0;
            slotData.slot0reward = 0;
            slotData.slot0description = "";
            Destroy(slots[0]);
            slotData.slot1type = 0;
            slotData.slot1reward = 0;
            slotData.slot1description = "";
            Destroy(slots[1]);
            slotData.slot2type = 0;
            slotData.slot2reward = 0;
            slotData.slot2description = "";
            Destroy(slots[2]);
            slotData.slot3type = 0;
            slotData.slot3reward = 0;
            slotData.slot3description = "";
            Destroy(slots[3]);
            slotData.slot4type = 0;
            slotData.slot4reward = 0;
            slotData.slot4description = "";
            Destroy(slots[5]);
            slotData.slot5type = 0;
            slotData.slot5reward = 0;
            slotData.slot5description = "";
            Destroy(slots[5]);
        }
        if(tarefasAtivas == 7)
        {
            slotData.slot0type = 0;
            slotData.slot0reward = 0;
            slotData.slot0description = "";
            Destroy(slots[0]);
            slotData.slot1type = 0;
            slotData.slot1reward = 0;
            slotData.slot1description = "";
            Destroy(slots[1]);
            slotData.slot2type = 0;
            slotData.slot2reward = 0;
            slotData.slot2description = "";
            Destroy(slots[2]);
            slotData.slot3type = 0;
            slotData.slot3reward = 0;
            slotData.slot3description = "";
            Destroy(slots[3]);
            slotData.slot4type = 0;
            slotData.slot4reward = 0;
            slotData.slot4description = "";
            Destroy(slots[5]);
            slotData.slot5type = 0;
            slotData.slot5reward = 0;
            slotData.slot5description = "";
            Destroy(slots[6]);
            slotData.slot6type = 0;
            slotData.slot6reward = 0;
            slotData.slot6description = "";
            Destroy(slots[6]);
        }
        if(tarefasAtivas == 8)
        {
            slotData.slot0type = 0;
            slotData.slot0reward = 0;
            slotData.slot0description = "";
            Destroy(slots[0]);
            slotData.slot1type = 0;
            slotData.slot1reward = 0;
            slotData.slot1description = "";
            Destroy(slots[1]);
            slotData.slot2type = 0;
            slotData.slot2reward = 0;
            slotData.slot2description = "";
            Destroy(slots[2]);
            slotData.slot3type = 0;
            slotData.slot3reward = 0;
            slotData.slot3description = "";
            Destroy(slots[3]);
            slotData.slot4type = 0;
            slotData.slot4reward = 0;
            slotData.slot4description = "";
            Destroy(slots[5]);
            slotData.slot5type = 0;
            slotData.slot5reward = 0;
            slotData.slot5description = "";
            Destroy(slots[6]);
            slotData.slot6type = 0;
            slotData.slot6reward = 0;
            slotData.slot6description = "";
            Destroy(slots[7]);
            slotData.slot7type = 0;
            slotData.slot7reward = 0;
            slotData.slot7description = "";
            Destroy(slots[7]);
        }
    }

    public void SavePlayer()
    {
        SaveSystem.instance.myTasksData.myActiveTasks = slotData.activeTasks;
        SaveSystem.instance.myTasksData.rewardData0 = slotData.slot0reward;
        SaveSystem.instance.myTasksData.rewardData1 = slotData.slot1reward;
        SaveSystem.instance.myTasksData.rewardData2 = slotData.slot2reward;
        SaveSystem.instance.myTasksData.rewardData3 = slotData.slot3reward;
        SaveSystem.instance.myTasksData.rewardData4 = slotData.slot4reward;
        SaveSystem.instance.myTasksData.rewardData5 = slotData.slot5reward;
        SaveSystem.instance.myTasksData.rewardData6 = slotData.slot6reward;
        SaveSystem.instance.myTasksData.rewardData7 = slotData.slot7reward;
        SaveSystem.instance.myTasksData.typeData0 = slotData.slot0type;
        SaveSystem.instance.myTasksData.typeData1 = slotData.slot1type;
        SaveSystem.instance.myTasksData.typeData2 = slotData.slot2type;
        SaveSystem.instance.myTasksData.typeData3 = slotData.slot3type;
        SaveSystem.instance.myTasksData.typeData4 = slotData.slot4type;
        SaveSystem.instance.myTasksData.typeData5 = slotData.slot5type;
        SaveSystem.instance.myTasksData.typeData6 = slotData.slot6type;
        SaveSystem.instance.myTasksData.typeData7 = slotData.slot7type;
        SaveSystem.instance.myTasksData.descriptionData0 = slotData.slot0description;
        SaveSystem.instance.myTasksData.descriptionData1 = slotData.slot1description;
        SaveSystem.instance.myTasksData.descriptionData2 = slotData.slot2description;
        SaveSystem.instance.myTasksData.descriptionData3 = slotData.slot3description;
        SaveSystem.instance.myTasksData.descriptionData4 = slotData.slot4description;
        SaveSystem.instance.myTasksData.descriptionData5 = slotData.slot5description;
        SaveSystem.instance.myTasksData.descriptionData6 = slotData.slot6description;
        SaveSystem.instance.myTasksData.descriptionData7 = slotData.slot7description;
        
        SaveSystem.instance.SaveTasks();
    }

    public void LoadPlayer()
    {
        SaveSystem.instance.LoadTasks();
        slotData.activeTasks = SaveSystem.instance.myTasksData.myActiveTasks;
        tarefasAtivas = SaveSystem.instance.myTasksData.myActiveTasks;
        slotData.slot0reward = SaveSystem.instance.myTasksData.rewardData0;
        slotData.slot1reward = SaveSystem.instance.myTasksData.rewardData1;
        slotData.slot2reward = SaveSystem.instance.myTasksData.rewardData2;
        slotData.slot3reward = SaveSystem.instance.myTasksData.rewardData3;
        slotData.slot4reward = SaveSystem.instance.myTasksData.rewardData4;
        slotData.slot5reward = SaveSystem.instance.myTasksData.rewardData5;
        slotData.slot6reward = SaveSystem.instance.myTasksData.rewardData6;
        slotData.slot7reward = SaveSystem.instance.myTasksData.rewardData7;
        slotData.slot0type = SaveSystem.instance.myTasksData.typeData0;
        slotData.slot1type = SaveSystem.instance.myTasksData.typeData1;
        slotData.slot2type = SaveSystem.instance.myTasksData.typeData2;
        slotData.slot3type = SaveSystem.instance.myTasksData.typeData3;
        slotData.slot4type = SaveSystem.instance.myTasksData.typeData4;
        slotData.slot5type = SaveSystem.instance.myTasksData.typeData5;
        slotData.slot6type = SaveSystem.instance.myTasksData.typeData6;
        slotData.slot7type = SaveSystem.instance.myTasksData.typeData7;
        slotData.slot0description = SaveSystem.instance.myTasksData.descriptionData0;
        slotData.slot1description = SaveSystem.instance.myTasksData.descriptionData1;
        slotData.slot2description = SaveSystem.instance.myTasksData.descriptionData2;
        slotData.slot3description = SaveSystem.instance.myTasksData.descriptionData3;
        slotData.slot4description = SaveSystem.instance.myTasksData.descriptionData4;
        slotData.slot5description = SaveSystem.instance.myTasksData.descriptionData5;
        slotData.slot6description = SaveSystem.instance.myTasksData.descriptionData6;
        slotData.slot7description = SaveSystem.instance.myTasksData.descriptionData7;
        //atualizarIcones
    }

    /*public void DeleteTask()
    {

    }*/
}
