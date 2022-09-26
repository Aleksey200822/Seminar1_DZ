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
Task19();
