/*
 * Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
 * a = 25, b = 5 -> да
 * a = 2, b = 10 -> нет
 * a = 9, b = -3 -> да
 * a = -3 b = 9 -> нет
 */

Console.WriteLine($"Введите первое число");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите первое число");
int num_2 = Convert.ToInt32(Console.ReadLine());

int square_2 = num_2 * num_2;

bool result = num_1 == square_2;

Console.WriteLine($"Результат: {result}");

/*   Напишите программу, которая будет выдавать название дня недели по заданному номеру.
 *   3 -> Среда
 *   5 -> Пятница
 */

Console.WriteLine($"Введите число для поиска дня недели");
int num = Convert.ToInt32(Console.ReadLine());

if(num != 3 & num != 5){ Console.WriteLine($"Сегодня выходной"); }
if(num == 3){ Console.WriteLine($"Сегодня среда"); }
if(num == 5){ Console.WriteLine($"Сегодня пятница"); }


Console.WriteLine($"---------------------");

/*   Напишите программу, которая будет выдавать название дня недели по заданному номеру.
 *   3 -> Среда
 *   5 -> Пятница
 */

switch (num)
{
    case 3:
        Console.WriteLine($"Сегодня среда");
        break;
    case 5:
        Console.WriteLine($"Сегодня пятница");
        break;
    default:
        Console.WriteLine($"Сегодня выходной");
        break;
}