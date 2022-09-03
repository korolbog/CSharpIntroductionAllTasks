/*
Задача 5
Напишите программу вычисления значения функции возведения
числа в квадрат.
*/
Task5();

void Task5()
{
    int randomNumber = new Random().Next(-10000,10001);
    Console.WriteLine($"Ваше случайное число: {randomNumber}");
    Console.WriteLine($"Квадрат числа: {Math.Pow(randomNumber, 2)}");
}
