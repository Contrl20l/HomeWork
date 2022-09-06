// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)


// Для ввода размера массива с клавиатуры
Console.WriteLine("Введите X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z:");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] array3D = new int[x, y, z];

//int[,,] array3D = new int[2, 2, 2];  // - для конкретного размера массива 
FillArray(array3D);
PrintIndex(array3D);
 Console.WriteLine();
// PrintArray(array3D);

// Функция вывода индекса элементов 3D массива
void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

// Функция заполнения 3D массива не повторяющимеся числами
void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}

// Функция выввода массива в структурированном виде
// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1); k++)
        
//         {
//             Console.Write(array[i, j, k] + " ");
//         }
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }