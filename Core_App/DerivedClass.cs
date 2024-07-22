//created by Codez
//on 6/6/2021
namespace Core_App;
public class AAA
{
	private int test;
	private int test2; // here

	public AAA(int test)
	{
		this.test = test;
	}
}
public class DerivedClass : BaseClass
{
	public DerivedClass(string name) : base(name){}

	public DerivedClass() : this("JaneDoe") { }

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// method to test smth
	/// </summary>
	public void Test()
	{
		Console.WriteLine();
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

	/// <summary>
	/// 
	/// </summary>
	public void Test()
	{
	}

}



public record User(string FirstName, string LastName, int Age)
{
	public void Deconstruct(
		out string firstName,
		out string lastName,
		out int    age)
	{
		this.ExtractUserDetails(out firstName, out lastName, out age);
	}

	private void ExtractUserDetails(
		out string firstName,
		out string lastName,
		out int    age)
	{
		firstName = this.FirstName;
		lastName = this.LastName;
		age = this.Age;
	}
}