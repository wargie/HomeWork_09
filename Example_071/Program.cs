//Задача 71: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int AckermanFunction(int M, int N)
    {
        if (M != 0)
            {
                if (N != 0) return AckermanFunction(M - 1, AckermanFunction(M, N - 1));
                return AckermanFunction(M - 1, 1);
            }

        return N + 1;
    }

Console.WriteLine(AckermanFunction(M, N));