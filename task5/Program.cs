//5)Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

public class Task5
{
	static void Main(string[] args)
	{
		int[] array = new int[8];
		for(int i = 0; i < 8; i++)
		{	
			Console.WriteLine("Введи "+ i +" элемент массива (0 или 1): ");
			array[i] = int.Parse(Console.ReadLine());	
		}
		
		Console.WriteLine("Массив: ");
		for(int i = 0; i < 8; i++)
			Console.WriteLine(array[i]);	

	}
}

