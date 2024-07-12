namespace Core_App;

public class BaseClass(string name)
{
    private BaseClass _instance;

    public virtual BaseClass GetInstance()
    {
        if (_instance == null) _instance = new BaseClass("Jane Does");

        return _instance;
    }
}