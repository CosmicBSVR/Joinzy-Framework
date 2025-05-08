using UnityEngine;

public class TestAccess : MonoBehaviour
{
    private void Start()
    {
        JoinzIn<GameManager>.Instance?.SayHello();
    }
}