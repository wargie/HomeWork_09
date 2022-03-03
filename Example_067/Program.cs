// Задача 67: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 6, 7, 8"


Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());


if (M >= N)
    {
        Console.Write("Необходимо ввести N больше M");
        return;
    }
    
    for (int i = M; i <= N; i++) {
        Console.Write("{0} ", i);
    }


/*void ShowNumberMToN(int M, N)
{
    if (M < N, M == N) 
        {
            Console.WriteLine("Число М должно быть больше N");
        }
    else 
        {
            if (number == 1) Console.Write(number);

            else
    {
        Console.Write(number);
        ShowNumberMToN(number - 1);
    }
}

int number = 10;
ShowNumberMToN(number);
*/