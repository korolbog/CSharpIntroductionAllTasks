/*
Задача 1
Напишите программу, которая на вход принимает два числа и
проверяет, является ли первое число квадратом второго.
*/

//Task1_Solution1();
Task1_Solution2();

void Task1_Solution1()
{
Console.WriteLine("Введите число 1: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber / secondNumber == secondNumber)
{
    Console.WriteLine("да, первое число - квадрат второго");
}
else
{
    Console.WriteLine("нет, первое число не является квадратом второго");
}
}

void Task1_Solution2()
{
Console.WriteLine("Введите число 1: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == Math.Pow(secondNumber, 2))
{
    Console.WriteLine("да, первое число - квадрат второго");
}    
else
{
    Console.WriteLine("нет, первое число не является квадратом второго");
}
}