using UnityEngine;
using UnityEngine.UI;

public class JoinzyUIButtonDestroyer : MonoBehaviour
{
    public string id;
    public Button button;

    private void Awake()
    {
        if (button == null)
            button = GetComponent<Button>();

        if (button != null)
            button.onClick.AddListener(DestroyByID);
    }

    private void DestroyByID()
    {
        var go = JoinzInID.Get<GameObject>(id + "_go");

        if (go != null)
        {
            Destroy(go);
            Debug.Log($"[JoinzyUI] Destroyed GameObject with ID '{id}_go'");
        }
        else
        {
            Debug.LogWarning($"[JoinzyUI] GameObject with ID '{id}_go' not found.");
        }
    }
}