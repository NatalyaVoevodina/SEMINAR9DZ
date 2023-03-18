//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

 void DescendingOrder(int n)
 {
    if(n==1)
    Console.Write(n+" ");
    else
    {
        Console.Write(n+" ");
        DescendingOrder(n-1);
    }
 }

Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
DescendingOrder(N);

