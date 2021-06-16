using UnityEngine; //Poder dar problema pq usa : Interactable

public class CreateTabela : MonoBehaviour //ItemPickup
{
    Tasks tasks;
    public CreateTask ct;
    // Start is called before the first frame update
    private void Start() {
        tasks = Tasks.instance;
    }
    public void CreateNew()
    {
        if(tasks != null)
        {
            tasks.Add(ct);
        }
        /*ct.description = "";
        ct.reward = 0;
        ct.type = 0;*/
    }
}
