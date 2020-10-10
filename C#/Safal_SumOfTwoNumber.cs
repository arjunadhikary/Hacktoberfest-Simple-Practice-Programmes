using System;

public class Program
{
	public static void Main()
	{
		Sum(8, 9);
	}
	public static void Sum(int a, int b)
	{
		int result = a + b;
		Console.WriteLine("The sum is {0}", result);
	}
}
