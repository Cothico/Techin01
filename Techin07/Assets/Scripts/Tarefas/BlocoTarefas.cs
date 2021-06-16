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


    private void Awake() {
        recompensa = botaoRecompensa.GetComponent<Image>();
        tipo = botaoTipo.GetComponent<Image>();
    }
    void Start()
    {
        slotData = FindObjectOfType<SlotData>();
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

    public void confirmTaskEdition()
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
        
        editorTabela.SetActive(false);
        //descricao.text = "";
        UpdateTaskData();
        //Debug.Log(currentDescricao + currentRecompensa + currentTipo+ " current things");
        //UpdateTasks
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
            //Debug.Log(tarefasAtivas + "actives On Create");
            //Debug.Log(slotData.currentSlot + "cur slot");
        }
        
    }

    /*public void DeleteTask()
    {

    }*/
}
