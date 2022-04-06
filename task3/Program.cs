//3)Подсчитать сумму цифр в числе
public class Task3
{
	static void Main(string[] args)
	{
		Console.WriteLine("Введи число: ");	
         int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                sum = sum + num % 10;
                num = num /10 ;
            }
        Console.WriteLine("Сумма цифр равна " + sum);
	}
}

