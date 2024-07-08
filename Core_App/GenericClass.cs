namespace Core_App;

public class GenericClass<T> where T : class
{
    public void Test()
    {
        string name = Extensions.GetGenericParameterName<T>();
    }

    private string GetGenericParameterName<T1>() where T1 : class
    {
        return typeof(T1).Name;
    }
}