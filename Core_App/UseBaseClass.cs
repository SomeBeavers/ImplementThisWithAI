namespace Core_App;

public class UseBaseClass
{
    public void Test(BaseClass baseClass, string name)
    {
        var instance = baseClass.GetInstance();

        var derivedClass = new DerivedClass(name);
        derivedClass.GetInstance();


        derivedClass.CreateIdentifiableNameFromListOfParameters(name, parameterFromDllName, parameterFromNamespaceName,
            parameterFromFullyQualifiedNameWithReplacedDots, [1, 2, 3, 4, 5]);
    }
}