using UnityEngine;

[CreateAssetMenu(fileName = "Tabela", menuName = "Tarefa")]
public class CreateTask : ScriptableObject //Item
{
    public int reward = 0;
    //public Sprite icon = null;
    public int type = 0;
    public string description = "";
}
