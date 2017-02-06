using System;

class Person
{
	private string myName = "N/A";
	private int myAge = 0;

	public string Name
	{
		get { return myName; }
		set { myName = value; }
	}

	public int Age
	{
		get { return myAge; }
		set { myAge = value; }
	}

	/// <summary>
	/// 重写Tostring()方法
	/// </summary>
	/// <returns></returns>
	public override string ToString()
	{
		return "Name = " + Name + ", Age = " + Age;
	}
}