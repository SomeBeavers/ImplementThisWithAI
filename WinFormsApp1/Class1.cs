namespace WinFormsApp1;

public class Class1
{
    public Class1()
    {
    }

    private string _name;

    public string Name
    {
        get
        {

        }
        set => this._name = value;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Method1()
    {
        Method3();
    }

    private void Method3()
    {
        return;

    }

    public void Test2()
    {
    }

    public void Method2()
    {
        // TODO
        var baseClass = Class1.BaseClass();
    }

    private static int BaseClass() => 1;
}