public static class JoinzIn<T>
{
    public static T Instance => JoinzyManager.Instance.Get<T>();
}