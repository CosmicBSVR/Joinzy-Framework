public static class JoinzInID
{
    public static T Get<T>(string id)
    {
        var result = JoinzyManager.Instance.GetByID(id);
        return result is T t ? t : default;
    }
}