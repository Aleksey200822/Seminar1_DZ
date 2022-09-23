void Task10()
/* Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.*/
{
    Console.Write("Введите трёхзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num > 99 && num < 1000)
    {
        Console.Write("Второе число: " + (num / 10  % 10));
    }
    else
    {
        Console.Write("Ошибка");
    }
}
//Task10();

void Task13()
/* Задача 13: Напишите программу, которая с помощью
деления выводит третью цифру заданного числа или
сообщает, что третьей цифры нет.*/
{
    Random random = new Random();
    int num = random.Next();
    //Console.Write("Введите число: ");
    //int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(num);
    if(num > 99)
    {
        while(num > 999)
        {
            num = num / 10;
        }
        Console.Write("Третье число: " + num % 10);
    }
    else
    {
        Console.WriteLine("Третьего числа нет");
    }
}
//Task13();

void Task15()
/* Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.*/
{
    Console.Write("Введите число от 1 до 7: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num > 0 && num < 8)
    {
        if(num > 5)
        {
            Console.Write("Выходной");
        }
        else
        {
            Console.WriteLine("Будний день");
        }
    }
    else
    {
        Console.WriteLine("Нету такого дня недели");
    }
}
Task15();