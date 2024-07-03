namespace Core_App;

public class Class1 : IDisposable
{
    private string _s;

    public void Method1(int[] unsortedInts, List<int> sortedList)
    {
        Console.WriteLine("Core_App.Class1.Method1");
        var s = InsertMembersToSortedList(unsortedInts, sortedList);
        
        new Class2(unsortedInts).Method2();
        new Class3().Method3();
        Console.WriteLine(s);
    }


    public void Dispose()
    {
        // TODO release managed resources here
    }
}

public class Class3
{
}
