void FillArray(int[] num, int minValue = 0,
                          int maxValue = 10)
{
    maxValue++;
    Random random = new Random();
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(minValue,maxValue);
    }
}

void PrintArray(int[] num)
{
    Console.WriteLine("Вывод массива: ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + "  ");
    }
    Console.WriteLine();
}

void Task34()
{
    /*Задача 34: Задайте массив заполненный случайными
    положительными трёхзначными числами. Напишите
    программу, которая покажет количество чётных чисел в
    массиве.*/
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 1000);
    PrintArray(numbers);
    EvenNumbersArray(numbers);
}

void EvenNumbersArray(int[] numbers)
{
    Console.WriteLine("Чётные числа: ");
    int count = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] % 2 == 0)
        {
            count++;
            Console.Write(numbers[i] + "  ");
        }
    }
    Console.WriteLine("Количество чётных чисел: " + count);
}
//Task34();

void Task36()
{
    /*Задача 36: Задайте одномерный массив, заполненный
    случайными числами. Найдите сумму элементов с
    нечётными индексами.*/
    int size = 6;
    int[] numbers = new int[size];
    FillArray(numbers, 1, 15);
    PrintArray(numbers);
    SumElementsNonEvenIndexes(numbers);
}
void SumElementsNonEvenIndexes(int[] numbers)
{
    int sum = 0;
    int size = numbers.Length;
    for(int i = 1; i < size; i += 2)
    {
        sum = sum + numbers[i];
    }
    Console.WriteLine("Сумма элементов с нечётными индексами: " + sum);
}
Task36();