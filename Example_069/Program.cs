//Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 15
//M = 4; N = 8 -> 5

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = SumNumber(M, N);

int SumNumber(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber) return firstNumber;
    else if (firstNumber > secondNumber) return firstNumber + SumNumber(firstNumber - 1, secondNumber);
            else return firstNumber + SumNumber(firstNumber + 1, secondNumber);
}

Console.WriteLine($"Сумма равна элементов от {M} до {N} равна {sum}");