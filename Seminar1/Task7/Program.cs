/*
Задача 7
Напишите программу, которая на вход принимает одно число (N),
а на выходе показывает все целые числа в промежутке от -N до N.
*/
//Task7_Solution1();
Task7_Solution2();
//Task7_Solution3();

void Task7_Solution1()
{
Console.WriteLine("Task7_Solution1");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;
var watch = new System.Diagnostics.Stopwatch();
watch.Start();
for (int i = 0; i < number*2+1; i++)
{
    result = ($"{result}{-number + i} ");     
}
Console.WriteLine(result);
watch.Stop();
Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
}




void Task7_Solution2()
{
Console.WriteLine("Task7_Solution2");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int interimNumber = -number;
string result = String.Empty;
var watch = new System.Diagnostics.Stopwatch();
watch.Start();
while (interimNumber <= number)
{
    result = ($"{result}{interimNumber} ");
    interimNumber++;
}
Console.WriteLine(result);
watch.Stop();
Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
}

void Task7_Solution3()
{
Console.WriteLine("Task7_Solution2");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = String.Empty;
var watch = new System.Diagnostics.Stopwatch();
watch.Start();
for (int interimNumber = -number; interimNumber <= number; interimNumber++)
{
    result = ($"{result}{interimNumber} ");
}
Console.WriteLine(result);
watch.Stop();
Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
}