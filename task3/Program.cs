/* Задача 5.Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
 */
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int number1 = -number;
System.Console.WriteLine(number);
while (number >= number1)
{
	System.Console.WriteLine(number1++);
	// ++number1;
}