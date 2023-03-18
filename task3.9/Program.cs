//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

uint AckermannFunction(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return AckermannFunction(n - 1, 1);
    else
        return AckermannFunction(n - 1, AckermannFunction(n, m - 1));
}
 
Console.WriteLine("Введите число M ");
uint M = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите число N ");
uint N = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine();
Console.Write($"М = {M} , N = {N} -> результат вычисления функции Аккермана = {AckermannFunction (M,N)}");