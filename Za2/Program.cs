// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] randomarray = new int[size];
    for(int index = 0; index < size; index++)
        randomarray[index] = new Random().Next(minValue, maxValue);
    return randomarray;
}
void ShowRandomArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i] + "   ");
        Console.WriteLine();
}
int SumOddNumbersPosition(int[] collection)
{
    int sum = 0;
    for(int i = 0; i<collection.Length; i++)
        if(i%2 != 0)
            sum += collection[i];
    return sum;
}

Console.WriteLine("Input size of array = ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value of array = ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array = ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] randomArray = RandomArray(size, minValue, maxValue);
ShowRandomArray(randomArray);
int Sum = SumOddNumbersPosition(randomArray);
Console.WriteLine(($" Sum of numbers not even positions in array = {Sum}"));
