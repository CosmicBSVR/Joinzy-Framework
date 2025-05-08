using UnityEngine;
using System.Collections;

public class JoinzyTest : MonoBehaviour
{
    public string id = "TestObject";

    private void Start()
    {
        Debug.Log("[JoinzyTest] Start() called.");
        StartCoroutine(WaitForJoinzyRefs());
    }

    private IEnumerator WaitForJoinzyRefs()
    {
        float timeout = 3f;
        float timer = 0f;

        while (timer < timeout)
        {
            var obj = JoinzInID.Get<Object>(id + "_obj");
            var go = JoinzInID.Get<GameObject>(id + "_go");

            if (obj != null || go != null)
            {
                Debug.Log(obj != null
                    ? $"[JoinzyTest] ✅ Object '{id}_obj' found: {obj.name}"
                    : $"[JoinzyTest] ❌ Object '{id}_obj' not found.");

                Debug.Log(go != null
                    ? $"[JoinzyTest] ✅ GameObject '{id}_go' found: {go.name}"
                    : $"[JoinzyTest] ❌ GameObject '{id}_go' not found.");

                yield break;
            }

            timer += 0.1f;
            yield return new WaitForSeconds(0.1f);
        }

        Debug.LogWarning($"[JoinzyTest] ❌ Timeout. Object/GameObject with ID '{id}' not registered in time.");
    }
}