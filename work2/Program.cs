//  Задайте массив заполненный случайными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[10];

int FilledInt(int start,int end){
    Random rnd=new Random();
    return rnd.Next(start,end);
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int num in array)
    {
        if (num % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
for(int i = 0; i < array.Length; i++)
{
    array[i]=FilledInt(100,999);
}
foreach (int num in array)
{
    Console.Write(num + " ");
}
Console.WriteLine();
Console.WriteLine(CountEvenNumbers(array));