using UnityEngine;

public class Character : MonoBehaviour, IMovable
{
    public void Move()
    {
        Run();
    }

    public void Run() => 
        Debug.Log("Character: Run");

    public void Walk() =>
        Debug.Log("Character: Walk");
}
