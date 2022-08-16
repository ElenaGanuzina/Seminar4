//вход - число, выход - количество цифр в числе.

int Figures(int number)
{
    int result = 0;
    while(number != 0)
    {
        number = number / 10;
        result++;
    }
    return result;
}

void PrintFigures(int number)
{
    Console.WriteLine(Figures(number));
}

PrintFigures(12345);
PrintFigures(2516);
PrintFigures(73);