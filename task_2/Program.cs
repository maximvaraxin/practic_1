﻿/*
 * Напишите программу, которая на вход принимает одно число 
 * (N), а на выходе показывает все целые числа в 
 * промежутке от -N до N.
 */

Console.WriteLine($"Введите размер диапазона");
int num = Convert.ToInt32(Console.ReadLine());
int count = -num;

while(count <= num)
{
    Console.WriteLine(count);
    count++;
}