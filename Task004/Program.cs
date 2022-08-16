// вывести массив из 8 элементов, заполненный 0 и 1 в случайном порядке.

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
} 

void PrintArray(int[] array)
{
    int count = array.Length;
    for(int index = 0; index < count; index++)
    {
        Console.Write(array[index] + " " );
    }
}

FillArray(8);
PrintArray(FillArray(8));