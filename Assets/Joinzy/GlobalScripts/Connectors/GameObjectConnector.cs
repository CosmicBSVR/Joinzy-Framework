using UnityEngine;

public class GameObjectConnector : MonoBehaviour
{
    public GameObject connected;

    private void Awake()
    {
        if (connected != null)
            JoinzyManager.Instance.Register(connected);
    }
}