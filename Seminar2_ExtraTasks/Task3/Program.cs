/*
На ввод подаётся рост трёх спортсменов.
Расположить их от большего к меньшему
*/


int numberOfAthletes = 9;
double[] athletes = new double[numberOfAthletes];
double height = 0;
Random random = new Random();
int posMin = 0;

HeightGenerator();
InsertionSort();
PrintAndConvertCentimetersToMeters();

void HeightGenerator()
{
Console.Write("Original array: ");
for (int i = 0; i < athletes.Length; i++)
{
    height = random.Next(155,211);
    athletes[i] = height;
    
    Console.Write($"{height} \t");
}
Console.WriteLine();
}

void InsertionSort()
{
    for (int j = 0; j < athletes.Length-1; j++)
    {
        for (int i = 0; i <= athletes.Length-j-1; i++)
        {
            if (athletes[i] < athletes[posMin])
            {
            posMin = i;
            } 
        }
        double temp = athletes[posMin];
        athletes[posMin] = athletes[athletes.Length-1-j];
        athletes[athletes.Length-1-j] = temp;
        posMin = 0;
    }
}
    
    
void PrintAndConvertCentimetersToMeters()
{
    Console.Write("Sorted array: ");
    for (int i = 0; i < athletes.Length; i++)
    {
        Console.Write($"{athletes[i]/100} \t");
    }
    Console.WriteLine();
}