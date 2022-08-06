//  принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine ());
int count = 1;
while (count < N)
{
    N = N - 1;
    int result = N % 2;
if (result == 0)
Console.Write(N + " ");
}
