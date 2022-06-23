/*7. Напишите программу, которая принимает на вход 
 * трёхзначное число и на выходе показывает последнюю
 * цифру этого числа.
 * 456 -> 6
 * 782 -> 2
 * 918 -> 8
*/

Console.WriteLine($"Введите число:");
string num = Console.ReadLine();

if (num.Length == 3) { Console.WriteLine($"Последняя цифра: {num[num.Length - 1]}"); }
else { Console.WriteLine($"Введено не 3-х значное число!"); }

Console.WriteLine($"---------");

Console.WriteLine($"Введите число(без проверки на 3 знака):");
int num_2 = Convert.ToInt32(Console.ReadLine());
int lastNumber = num_2 % 10;
Console.WriteLine($"Последняя цифра: {lastNumber}");