//4)Написать программу вычисления произведения чисел от 1 до N
public class Task4
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введи число N: ");
		int n = int.Parse(Console.ReadLine());
		int prod = 1;
		
		for(int i = 1; i <= n; i++)
			prod = prod * i;	
			
		Console.WriteLine("Произведение чисел равно " + prod);
	}
}
