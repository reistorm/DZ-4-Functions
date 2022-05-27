// Напишите программу, которая задаёт массив 
// целых чисел и выводит их на экран.
// Размер массива определяется пользователем.


void FillArray()
{
    Console.WriteLine("Введите число элементов массива: ");
    int N = int.Parse(Console.ReadLine());
    int[] arr = new int[N];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 100);
        Console.Write(arr[i] + ", ");
    }
    return;
}

FillArray();
Console.WriteLine();

//int[] initArray []
{
    Console.WriteLine("Введите число элементов массива: );
    int N = int.Parse(Console.ReadLine());
    int [] arr = new int[N];
    Console.Write("[ ");
    for (int i = 0; i < arr.Lenght; i++)
    { 
       arr[i] = rand.Next(0, 100);
       Console.Write(arr[i] + ", ");
       Console.Write("] ");
    } 
    return arr;
}




