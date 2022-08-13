int number = new Random().Next(10, 100);
System.Console.WriteLine($"Случайное число = {number}");
int digit2 = number % 10;
int digit1 = number / 10;
if (digit1 > digit2)
{
	System.Console.WriteLine($"Максимальная цифра числа первая и равна: {digit1}");
}
else
{
	System.Console.WriteLine($"Максимальная цифра числа вторая и равна: {digit2}");
}