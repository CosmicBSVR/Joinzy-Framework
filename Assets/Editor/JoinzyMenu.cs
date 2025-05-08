using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class JoinzyMenu
{
    [MenuItem("Joinzy/Create/Joinzy Manager")]
    public static void CreateJoinzyManager()
    {
        var go = new GameObject("JoinzyManager");
        go.AddComponent<JoinzyManager>();
        Undo.RegisterCreatedObjectUndo(go, "Create JoinzyManager");
        Selection.activeGameObject = go;
    }

    [MenuItem("Joinzy/Create/Scene Linker")]
    public static void CreateSceneLinker()
    {
        var go = new GameObject("SceneLinker");
        go.AddComponent<SceneLinker>();
        Undo.RegisterCreatedObjectUndo(go, "Create SceneLinker");
        Selection.activeGameObject = go;
    }

    [MenuItem("Joinzy/Create/GameObject Connector")]
    public static void CreateGameObjectConnector()
    {
        var go = new GameObject("GameObjectConnector");
        go.AddComponent<GameObjectConnector>();
        Undo.RegisterCreatedObjectUndo(go, "Create GameObjectConnector");
        Selection.activeGameObject = go;
    }

    [MenuItem("Joinzy/Test/Test JoinzIn<T>")]
    public static void TestJoinzIn()
    {
        var instance = JoinzIn<GameManager>.Instance;
        if (instance != null)
        {
            Debug.Log("[Joinzy Test] JoinzIn<GameManager> works: " + instance.name);
            instance.SayHello();
        }
        else
        {
            Debug.LogWarning("[Joinzy Test] JoinzIn<GameManager> not found.");
        }
    }

    [MenuItem("Joinzy/Test/Test JoinzInID")]
    public static void TestJoinzInID()
    {
        var obj = JoinzInID.Get<GameObject>("Player1");
        if (obj != null)
            Debug.Log("[Joinzy Test] JoinzInID found: " + obj.name);
        else
            Debug.LogWarning("[Joinzy Test] JoinzInID 'Player1' not found.");
    }

    [MenuItem("Joinzy/Test/Test GameObjectConnector")]
    public static void TestGameObjectConnector()
    {
        var obj = JoinzIn<GameObject>.Instance;
        if (obj != null)
            Debug.Log("[Joinzy Test] GameObjectConnector works: " + obj.name);
        else
            Debug.LogWarning("[Joinzy Test] GameObjectConnector not found.");
    }

    [MenuItem("Joinzy/Test/Test DontDestroyOnLoad")]
    public static void TestDontDestroyOnLoad()
    {
        var go = new GameObject("TestPersist");
        Object.DontDestroyOnLoad(go);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("[Joinzy Test] Reloading scene. Object should persist.");
    }

    [MenuItem("Joinzy/Create/Joinzy Tester")]
    public static void CreateJoinzyTester()
    {
        var go = new GameObject("JoinzyTester");
        go.AddComponent<JoinzyTest>();
        Undo.RegisterCreatedObjectUndo(go, "Create JoinzyTester");
        Selection.activeGameObject = go;
    }
}