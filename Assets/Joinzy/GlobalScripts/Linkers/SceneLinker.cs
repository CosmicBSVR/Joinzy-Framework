using UnityEngine;

public class SceneLinker : MonoBehaviour
{
    public string ID;
    public Object targetObject;
    public GameObject targetGameObject;

    private void Start()
    {
        if (!string.IsNullOrEmpty(ID))
        {
            if (targetObject != null)
                JoinzyManager.Instance?.RegisterID(ID + "_obj", targetObject);

            if (targetGameObject != null)
                JoinzyManager.Instance?.RegisterID(ID + "_go", targetGameObject);
        }
    }
}