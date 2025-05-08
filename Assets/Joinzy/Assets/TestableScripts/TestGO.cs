using UnityEngine;

public class TestGO : MonoBehaviour
{
    private void Start()
    {
        var obj = JoinzIn<GameObject>.Instance;
        if (obj != null)
            Debug.Log("Connected GO: " + obj.name);
    }
}