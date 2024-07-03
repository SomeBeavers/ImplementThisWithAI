namespace Core_App;

public class UseBaseClass
{
    public void Test(BaseClass baseClass)
    {
        var instance = baseClass.GetInstance();
    }
}