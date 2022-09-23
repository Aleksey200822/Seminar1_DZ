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
Task10();
