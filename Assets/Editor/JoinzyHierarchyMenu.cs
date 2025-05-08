using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class JoinzyHierarchyMenu
{
    [MenuItem("GameObject/Joinzy/Joinzy Manager", false, 10)]
    public static void CreateJoinzyManager(MenuCommand menuCommand)
    {
        var go = new GameObject("JoinzyManager");
        go.AddComponent<JoinzyManager>();
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
        Undo.RegisterCreatedObjectUndo(go, "Create JoinzyManager");
        Selection.activeObject = go;
    }

    [MenuItem("GameObject/Joinzy/Scene Linker", false, 10)]
    public static void CreateSceneLinker(MenuCommand menuCommand)
    {
        var go = new GameObject("SceneLinker");
        go.AddComponent<SceneLinker>();
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
        Undo.RegisterCreatedObjectUndo(go, "Create SceneLinker");
        Selection.activeObject = go;
    }

    [MenuItem("GameObject/Joinzy/GameObject Connector", false, 10)]
    public static void CreateGameObjectConnector(MenuCommand menuCommand)
    {
        var go = new GameObject("GameObjectConnector");
        go.AddComponent<GameObjectConnector>();
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
        Undo.RegisterCreatedObjectUndo(go, "Create GameObjectConnector");
        Selection.activeObject = go;
    }

    [MenuItem("GameObject/Joinzy/Test/Test JoinzIn<T>", false, 20)]
    public static void TestJoinzIn(MenuCommand menuCommand)
    {
        var instance = JoinzIn<GameManager>.Instance;
        if (instance != null)
        {
            Debug.Log("[Joinzy Test] JoinzIn<GameManager> Working: " + instance.name);
            instance.SayHello();
        }
        else
        {
            Debug.LogWarning("[Joinzy Test] JoinzIn<GameManager> Not founded.");
        }
    }

    [MenuItem("GameObject/Joinzy/Test/Test JoinzInID", false, 20)]
    public static void TestJoinzInID(MenuCommand menuCommand)
    {
        var obj = JoinzInID.Get<GameObject>("Player1");
        if (obj != null)
            Debug.Log("[Joinzy Test] JoinzInID Founded: " + obj.name);
        else
            Debug.LogWarning("[Joinzy Test] JoinzInID 'Player1' Not founded.");
    }

    [MenuItem("GameObject/Joinzy/Test/Test GameObjectConnector", false, 20)]
    public static void TestGameObjectConnector(MenuCommand menuCommand)
    {
        var obj = JoinzIn<GameObject>.Instance;
        if (obj != null)
            Debug.Log("[Joinzy Test] GameObjectConnector work: " + obj.name);
        else
            Debug.LogWarning("[Joinzy Test] GameObjectConnector Not founded.");
    }

    [MenuItem("GameObject/Joinzy/Test/Test DontDestroyOnLoad", false, 20)]
    public static void TestDontDestroyOnLoad(MenuCommand menuCommand)
    {
        var go = new GameObject("TestPersist");
        Object.DontDestroyOnLoad(go);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("[Joinzy Test] Restarting the scene, the object is not gonna be deleted.");
    }

    [MenuItem("GameObject/Joinzy/Joinzy Tester", false, 10)]
    public static void CreateJoinzyTester(MenuCommand menuCommand)
    {
        var go = new GameObject("JoinzyTester");
        go.AddComponent<JoinzyTest>();
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
        Undo.RegisterCreatedObjectUndo(go, "Create JoinzyTester");
        Selection.activeObject = go;
    }
}