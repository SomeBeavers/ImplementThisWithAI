namespace Core_App;

public class Class1 : IDisposable
{
    private string _s;

    public void Method1(int[] unsortedInts, List<int> sortedList)
    {
        Console.WriteLine("Core_App.Class1.Method1");
        var s = InsertMembersToSortedList(unsortedInts, sortedList);
        
        new Class2(unsortedInts).Method2();
    }

    public string S
    {
        get { }
        set => _s = value;
    }

    public void Dispose()
    {
        // TODO release managed resources here
    }
}