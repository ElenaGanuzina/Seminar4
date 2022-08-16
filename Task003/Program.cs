// вход - число, выход !числа.

int Factorial(int n)
{
    int result = 1;
    for(int number = 1; number <= n; number++)
    {
        result *= number;
    }
    return result;
}

void PrintFactorial(int n)
{
    Console.WriteLine($"Факториал числа {n} равен {Factorial(n)}");
}

PrintFactorial(10);
PrintFactorial(5);
PrintFactorial(0);
