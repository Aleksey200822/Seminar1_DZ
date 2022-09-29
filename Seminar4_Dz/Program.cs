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