using System;
using System.Collections.Generic;
using UnityEngine;

public class JoinzyManager : MonoBehaviour
{
    public static JoinzyManager Instance { get; private set; }

    private Dictionary<Type, object> registry = new Dictionary<Type, object>();
    private Dictionary<string, object> idRegistry = new Dictionary<string, object>();

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Register<T>(T instance)
    {
        var type = typeof(T);
        if (!registry.ContainsKey(type))
            registry[type] = instance;
    }

    public void RegisterID(string id, object obj)
    {
        if (!string.IsNullOrEmpty(id))
            idRegistry[id] = obj;
    }

    public T Get<T>()
    {
        var type = typeof(T);
        if (registry.TryGetValue(type, out var instance))
            return (T)instance;
        return default;
    }

    public object GetByID(string id)
    {
        if (idRegistry.TryGetValue(id, out var obj))
            return obj;
        return null;
    }
    
    private void OnDestroy()
    {
        Debug.Log("JoinzyManager destroyed!");
    }
}