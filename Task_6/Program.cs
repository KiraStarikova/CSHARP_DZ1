// принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine ());
int result = num % 2;
if (result == 0)
{
Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}