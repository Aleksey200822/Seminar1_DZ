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

void FillArrayDouble(double[] num, int minValue = 0,
                                   int maxValue = 10)
{
    maxValue++;
    Random random = new Random();
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = Math.Round(random.NextDouble() * 30 - 15, 2);
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

void PrintArrayDouble(double[] num)
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
//Task36();

void Task38()
{
    /*Задача 38: Задайте массив вещественных чисел. Найдите
    разницу между максимальным и минимальным элементов
    массива.*/
    int size = 6;
    double[] numbers = new double[size];
    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);
    MinMaxElementsArray(numbers);   
}

 void MinMaxElementsArray(double[] numbers)
 {
    double min = 0;
    double max = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] < min)
        {
            min = numbers[i];
        }
        if(numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    Console.WriteLine($"Максимальное: {max}  Минимальное: {min}  Разница: {max - min}");
 }
//Task38();

void Task41()
{
    /*Задача 41: Пользователь вводит с клавиатуры M чисел.
    Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

    Console.Write("Введите количество чисел: ");
    int countNumbers = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for(int i = 0; i < countNumbers; i++)
    {
        Console.WriteLine($"Введите {i +1} число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0)
        {
            count++;
        }
    }
    Console.WriteLine("Количество положительных чисел: " + count);
}
//Task41();