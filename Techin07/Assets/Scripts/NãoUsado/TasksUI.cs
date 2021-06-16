using UnityEngine;

public class TasksUI : MonoBehaviour //inventoryUI
{
    public Transform slotsGroup;
    Tasks tasks;
    TaskSlot[] slots;
    // Start is called before the first frame update
    void Start()
    {
        tasks = Tasks.instance;
        if(tasks != null)
        {
            tasks.onTaskChangedCallback += UpdateUI;
        }
        

        slots = slotsGroup.GetComponentsInChildren<TaskSlot>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void UpdateUI()
    {
        for(int i = 0; i < slots.Length; i++)
        {
            if(i < tasks.tasks.Count)
            {
                slots[i].AddTask(tasks.tasks[i]);
            }else
            {
                slots[i].ClearSlot();
            }
        }
        Debug.Log("Upd UI");
    }
}
