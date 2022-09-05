/*
Даны два числа a, b, такие что a < b. Вывести на экран сколько раз
число a поместится в числе b
*/
var watch = new System.Diagnostics.Stopwatch();
watch.Start();
int a = new Random().Next(1,51);
int b = new Random().Next(51,101);
Console.WriteLine($"Число a = {a} поместится в число b = {b} следующее количество раз: {b/a}");
watch.Stop();
Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");