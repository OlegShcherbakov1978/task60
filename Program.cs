// Задача 60. ...Сформируйте трёхмерный массив
// из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] Array()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
    begin:
        array[i] = (new Random().Next(10, 100));
        for (int j = 0; j < i; j++)
        {
            if (array[j] == array[i])
            {
                goto begin;
            }
        }
    }
    return array;
}

int[,,] Array3D(int[] array)
{
    int i = 0;
    int[,,] array3d = new int[2, 2, 2];
    for (int x = 0; x < 2; x++)
    {
        for (int y = 0; y < 2; y++)
        {
            for (int z = 0; z < 2; z++)
            {
                array3d[x, y, z] = array[i];
                i++;
            }
        }
    }
    return array3d;
}

void Print3D(int[,,] array3d)
{
    for (int x = 0; x < 2; x++)
    {
        for (int y = 0; y < 2; y++)
        {
            for (int z = 0; z < 2; z++)
            {
                System.Console.Write($"{array3d[x, y, z]} ({x}, {y}, {z})  ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
        }
    }
}

int[] arr = Array();
int[,,] arr3d = Array3D(arr);
Print3D(arr3d);
