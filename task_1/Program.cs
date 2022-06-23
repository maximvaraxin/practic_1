//task_1 in hall / num_1 == square_2

Console.WriteLine($"Введите первое число");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите первое число");
int num_2 = Convert.ToInt32(Console.ReadLine());

int square_2 = num_2 * num_2;

bool result = num_1 == square_2;

Console.WriteLine($"Результат: {result}");

//day{1,2,3...}
Console.WriteLine($"Введите число для поиска дня недели");
int num = Convert.ToInt32(Console.ReadLine());


if(num == 1){ Console.WriteLine($"Сегодня понедельник"); }
if(num == 2){ Console.WriteLine($"Сегодня вторник"); }
if(num == 2){ Console.WriteLine($"Сегодня среда"); }
if(num == 2){ Console.WriteLine($"Сегодня четверг"); }
if(num == 2){ Console.WriteLine($"Сегодня пятница"); }
if(num == 2){ Console.WriteLine($"Сегодня суббота"); }
if(num == 2){ Console.WriteLine($"Сегодня воскресенье"); }
if(num < 1 || num > 7 ){ Console.WriteLine($"Введено неверное число"); }
