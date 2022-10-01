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