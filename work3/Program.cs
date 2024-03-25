// : Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

int[] array = new int[10];

int FilledInt(int start,int end){
    Random rnd=new Random();
    return rnd.Next(start,end);
}

void PrintArray(int[] array)
{
    foreach (int num in array)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

int[] ReverseArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[length - i - 1];
        array[length - i - 1] = temp;
    }
    return array;
}

for(int i = 0; i < array.Length; i++)
{
    array[i]=FilledInt(1,10);
}
Console.WriteLine("Исходный массив:");
PrintArray(array);

Console.WriteLine("\nПеревернутый массив:");
PrintArray(ReverseArray(array));
