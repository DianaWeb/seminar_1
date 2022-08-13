/* Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98 */
int number = new Random().Next(100, 1000);
System.Console.WriteLine($"Случайное число = {number}");
int digit1 = number / 100;
int digit3 = number % 10;
// System.Console.Write(digit1);
// System.Console.Write(digit3);
System.Console.WriteLine($"Результат выполнения равен {digit1 * 10 + digit3}");