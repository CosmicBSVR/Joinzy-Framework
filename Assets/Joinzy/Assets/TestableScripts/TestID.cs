using UnityEngine;

public class TestID : MonoBehaviour
{
    private void Start()
    {
        var obj = JoinzInID.Get<GameObject>("Player1");
        if (obj != null)
            Debug.Log("ID Object is founded: " + obj.name);
        else
            Debug.LogWarning("ID Object not founded!");
    }
}