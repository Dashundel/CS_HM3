//1)Найти кубы чисел от 1 до N
public class Task1
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введи число N: ");
		int n = int.Parse(Console.ReadLine());
		
		for(int i = 0; i <= n; i++)
			Console.WriteLine("Куб числа " + i + " равен " + i*i*i);
	}
}	

