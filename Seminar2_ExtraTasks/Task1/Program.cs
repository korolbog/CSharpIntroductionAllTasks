/*
Пользователь вводит число N (N > 0). Программа должна вывести N
единиц на экран
*/
Task1CycleFor();
//Task1CycleWhile();

void Task1CycleFor()
{
var watch = new System.Diagnostics.Stopwatch();
watch.Start();
int number = new Random().Next(1000,1001);
string result = String.Empty;

Console.Write("Ваше случайное число (for):");
Console.WriteLine(number);

for (int i = 0; i < number; i++)
{
    result += "1 ";
}
Console.WriteLine(result.Remove(result.Length-1,1));
watch.Stop();
Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
}

void Task1CycleWhile()
{
var watch = new System.Diagnostics.Stopwatch();
watch.Start();
int number = new Random().Next(1000,1001);
int i = 0;
string result = String.Empty;

Console.Write("Ваше случайное число (while):");
Console.WriteLine(number);

while (i < number)
{
    result += "1 ";
    i++;
}
Console.WriteLine(result.Remove(result.Length-1,1));
watch.Stop();
Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
}