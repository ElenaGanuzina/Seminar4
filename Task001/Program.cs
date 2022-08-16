// вход - число А, выход - сумма чисел от 1 до А.

int Sum(int a)
{
    int result = 0;
    for(int number = 0; number <= a; number++)
    {
        result += number;
    }
    return result;
}

void PrintSum(int a)
{
    Console.WriteLine($"Сумма числе от 1 до {a} равна {Sum(a)}");
}

PrintSum(10);
PrintSum(-5);
PrintSum(0);