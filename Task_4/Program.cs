﻿// на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите первое число ");
int num = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите третье число ");
int num3 = Convert.ToInt32(Console.ReadLine ());
int max = num;
if (num > max) max = num;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
Console.WriteLine($"Наибольшее число {max}");
