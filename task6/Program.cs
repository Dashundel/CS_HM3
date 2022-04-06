//6)Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

public class Task6
{
	static void Main(string[] args)
	{
		int[] array = new int[12];
		for(int i = 0; i < 12; i++)
		{	
			Console.WriteLine("Введи "+ i +" элемент массива (число от -9 до 9): ");
			array[i] = int.Parse(Console.ReadLine());
			if (array[i] > 9 || array[i] < -9)
			{
				Console.WriteLine("Введено не корректное число. Попробуй еще раз: ");
				array[i] = int.Parse(Console.ReadLine());
			}
		}
		
		Console.WriteLine("Массив: ");
		for(int i = 0; i < 12; i++)
			Console.WriteLine(array[i]);
			
		Console.WriteLine("Сумму каких элементов посчитать? Если положительных введи 1. Если отрицательных - 0 : ");
		int type = int.Parse(Console.ReadLine());
		
		int sum = 0;
		if (type == 1)
		{
			for(int i = 0; i < 12; i++)
				if (array[i] > 0) sum = sum + array[i];
		}
		else if (type == 0)
		{
			for(int i = 0; i < 12; i++)
				if (array[i] < 0) sum = sum + array[i];
		}
		else Console.WriteLine("Введено не корректное число");

		Console.WriteLine("Сумма равна: " + sum);

	}
}

