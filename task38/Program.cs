// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] array = new double[10];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine ("Введите элемент массива:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
double min = array[0];
double max = array[0];
for (int i = 0; i< array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    else if (array[i] > max)
    {
        max = array[i];
    }
}
double res = max - min;
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {res}");