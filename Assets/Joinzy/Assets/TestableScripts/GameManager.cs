using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        JoinzyManager.Instance.Register(this);
    }

    public void SayHello()
    {
        Debug.Log("Hello from GameManager!");
    }
}