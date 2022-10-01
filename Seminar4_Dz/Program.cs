void Task25()
/*Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.*/
{
    Console.Write("Введите число А: ");
    int numA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int numB = Convert.ToInt32(Console.ReadLine());
    int comp = numA;
    stepen( numA, numB, comp);
}
void stepen(int numA, int numB, int comp)
{
    for(int i = 1; i < numB; i++)
    {
        comp = comp * numA;
    }
    Console.WriteLine($"{numA} в {numB} степини = " + comp);
}


Task25();

void Task27()
/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while (number > 0)
    {
        int num = number % 10;
        number = number / 10;
        sum = sum + num;
    }
    Console.WriteLine("Сумма всех цифр в числе: " + sum);
}
//Task27();

void Task29()
/*Задача 29: Напишите программу, которая задаёт массив
из 8 случайных целых чисел и выводит отсортированный
по модулю массив.*/
{
     int[] fillArray()
    {
        Random random = new Random();
        int size = 8;
        int[] numbers = new int[size];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-20, 20);
        }
        return numbers;
    }
    int[] Sort(int[] arr1)
    {
        for (int i = 0; i < arr1.Length; i++)
            for (int j = i; j < arr1.Length; j++)
                if (Math.Abs(arr1[j]) < Math.Abs(arr1[i]))
                {
                    int temp = arr1[j];
                    arr1[j] = arr1[i];
                    arr1[i] = temp;
                }
        return arr1;
    }
    void printArray(int[] arr2)
    {
        for (int i = 0; i < arr2.Length; i++)
            if (i < arr2.Length - 1)
                Console.Write(arr2[i] + ", ");
            else
                Console.Write(arr2[i]);
        Console.WriteLine(" ");
    }
    int[] arrForSort = fillArray();
    printArray(arrForSort);
    Console.WriteLine("После сортировки по модулю: ");
    printArray(Sort(arrForSort));
}
//Task29();