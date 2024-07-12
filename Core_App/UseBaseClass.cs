namespace Core_App;

public class UseBaseClass
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="baseClass"></param>
    /// <param name="name"></param>
    public void Test(BaseClass baseClass, string name)
    {
        var instance = baseClass.GetInstance();

        var derivedClass = new DerivedClass(name);
        derivedClass.GetInstance();


        var identifiableNameFromListOfParameters = derivedClass.CreateIdentifiableNameFromListOfParameters(name, parameterFromDllName, parameterFromNamespaceName,
            parameterFromFullyQualifiedNameWithReplacedDots, [1, 2, 3, 4, 5]);
    }

    public void Test2()
    {

    }
}