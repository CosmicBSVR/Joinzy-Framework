using UnityEngine;
using UnityEngine.UI;

public class JoinzyUIButtonConnector : MonoBehaviour
{
    public string id;
    public Button button;

    private void Awake()
    {
        if (button == null)
            button = GetComponent<Button>();

        if (button != null)
            button.onClick.AddListener(ConnectToID);
    }

    private void ConnectToID()
    {
        var go = JoinzInID.Get<GameObject>(id + "_go");

        if (go != null)
        {
            go.SetActive(!go.activeSelf);
            Debug.Log($"[JoinzyUI] Toggled object: {go.name}");
        }
        else
        {
            Debug.LogWarning($"[JoinzyUI] ID '{id}_go' not found.");
        }
    }
}