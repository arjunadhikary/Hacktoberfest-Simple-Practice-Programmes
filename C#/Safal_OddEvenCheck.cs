using System;

public class Program
{
	public static void Main()
	{
		OddEven();
	}
	public static void OddEven()
	{
		Console.WriteLine("Enter a number");
		int number = Convert.ToInt32(Console.ReadLine());
		if (number % 2 == 0)
		{
			Console.WriteLine("Number {0} is even", number);
		}
		else
		{
			Console.WriteLine("Number {0} is odd", number);
		}

	}
}