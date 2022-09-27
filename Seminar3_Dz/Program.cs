void Task19()
/*Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/
{
    Console.WriteLine("Введите пятизначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int num1 = num / 10000;
    int num2 = (num / 1000) % 10;
    int num3 = (num / 100) % 10;
    int num4 = (num / 10) % 10;
    int num5 = num % 10;
    Polindrome(num, num1, num2, num3, num4, num5);
}

void Polindrome(int num, int num1, int num2, int num3, int num4, int num5)
{
    if(num > 9999 && num < 100000)
    {
        if(num1 == num5 && num2 == num4)
        {
            Console.Write("Число является полиндромом");
        }
        else
        {
            Console.Write("Число не является полиндромом");
        }
    }
    else
    {
        Console.Write("Неправильно набран номер");
    }
}
//Task19();

void Task21()
/* Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.*/
{
    Console.Write ("Введите координаты x1: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координаты y1: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координаты z1: ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координаты x2: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координаты y2: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координаты z2: ");
    int z2 = Convert.ToInt32(Console.ReadLine());
    {
    double length = Math.Round(Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2)),2);
    Console.WriteLine("Расстояние: " + length);
    }
}
//Task21();

void Task23()
/* Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/
{
    Console.Write ("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число\tКуб");
    
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine("{0}\t{1}\t", i, Math.Pow(i,3) );
    }
}
Task23();