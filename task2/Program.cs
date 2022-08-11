System.Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (0 < number & number < 8)
{
	if (number == 1)
	{
		System.Console.WriteLine("Понедельник");
	}
	if (number == 2)
	{
		System.Console.WriteLine("Вторник");
	}
	if (number == 3)
	{
		System.Console.WriteLine("Среда");
	}
	if (number == 4)
	{
		System.Console.WriteLine("Четверг");
	}
	if (number == 5)
	{
		System.Console.WriteLine("Пятница");
	}
	if (number == 6)
	{
		System.Console.WriteLine("Суббота");
	}
	if (number == 7)
	{
		System.Console.WriteLine("Воскресенье");
	}
}
else
{
	System.Console.WriteLine("Введенное число не соответсвует требованию!");
}

