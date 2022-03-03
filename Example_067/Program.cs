// Задача 67: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 6, 7, 8"


Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = M; i <= N; i++)
    {
        Console.Write($"{i} ");
    }

if (M >= N)
    {
        Console.Write("Необходимо ввести N больше M");
        return;
    }