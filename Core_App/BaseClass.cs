namespace Core_App;

public class BaseClass
{
    private BaseClass _instance;

    public virtual BaseClass GetInstance()
    {
        if (_instance == null) _instance = new BaseClass();

        return _instance;
    }
}