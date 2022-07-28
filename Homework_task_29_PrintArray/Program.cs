// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
int n = array.Length;
//Console.WriteLine(n);

int[] FillArray(int n)
{
    for(int i=0; i<n; i++)
    {
        array[i] = new Random().Next(1,100);
    }
    return array;
}

Console.Write("[{0}]", string.Join(", ", FillArray(n)));