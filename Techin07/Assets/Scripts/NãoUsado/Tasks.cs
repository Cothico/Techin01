using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasks : MonoBehaviour //inventory
{
    #region Singleton
    public static Tasks instance;
    private void Awake() 
    {
        if(instance != null)
        {
            Debug.Log("More than 1 of tasks inventory");
        }
        instance = this;    
    }
    #endregion

    public delegate void OnTaskChanged();
    public OnTaskChanged onTaskChangedCallback;
    public int space = 32;
    public List<CreateTask> tasks = new List<CreateTask>();
    public void Add(CreateTask task)
    {
        if(tasks.Count >= space)
        {
            Debug.Log("Limite de tarefas atingido.");
        }
        else{
            tasks.Add(task);
            if(onTaskChangedCallback != null)
            {
                onTaskChangedCallback.Invoke();
            }
        }
        
    }

    public void Remove (CreateTask task)
    {
        tasks.Remove(task);
        if(onTaskChangedCallback != null)
            {
                onTaskChangedCallback.Invoke();
            }
    }
}
