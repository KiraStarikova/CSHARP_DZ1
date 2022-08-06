// на вход принимает два числа и выдаёт, какое число большее
Console.WriteLine("Введите первое число ");
int num = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine ());
int max = num;
if (num >= max) max = num;
if (num2 > max) max = num2;
Console.WriteLine($"Наибольшее число {max}");