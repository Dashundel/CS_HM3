//2)Найти сумму чисел от 1 до А
public class Task2
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введи число A: ");
		int a = int.Parse(Console.ReadLine());
		int sum = 0;
		
		for(int i = 0; i <= a; i++)
			sum = sum + i;	
			
		Console.WriteLine("Сумма чисел равна " + sum);
	}
}

