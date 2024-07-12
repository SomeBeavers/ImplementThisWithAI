namespace Core_App;

public class Class1 : IDisposable
{
    private string _s;
    delegate void Del(string message);

    public void Method1(int[] unsortedInts, List<int> sortedList)
    {
        Console.WriteLine("Core_App.Class1.Method1");
        var s = InsertMembersToSortedList(unsortedInts, sortedList);


        sortedList.Where(x => IsEven(x));
        Del handler = A;
        new Class2(unsortedInts).Method2();
        new Class3().Method3();
        Console.WriteLine(s);
    }

    private void A(
        string message) {
        Dispose();
    }
}

public class Class3
{
    /// <summary>
    /// 
    /// </summary>
	public void Test() { /*Test2();*/}
    
	private void Test2()
	{
		throw new NotImplementedException();
	}

	public void TT()
	{
		TODO;
	}
}
