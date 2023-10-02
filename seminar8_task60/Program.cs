// Задача 60: Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить 
// массив, добавляя индексы каждого элемента.

int[, ,] Generate_Random_Array(int sizeX, int sizeY, int sizeZ) //метод для генерация случайного трёхмерного массива
    {
        Random random = new Random();
        int[, ,] array = new int[sizeX, sizeY, sizeZ];

        for (int x = 0; x < sizeX; x++)
        {
            for (int y = 0; y < sizeY; y++)
            {
                for (int z = 0; z < sizeZ; z++)
                {
                    array[x, y, z] = random.Next(1, 100);
                }
            }
        }

        return array;
    }

void Print_3D_Array(int[,,] array) //метод для печати трёхмерного массива вместе с индексами каждого элемента 
    {
        int dimension1Length = array.GetLength(0);
        int dimension2Length = array.GetLength(1);
        int dimension3Length = array.GetLength(2);

        for (int i = 0; i < dimension1Length; i++)
        {
            for (int j = 0; j < dimension2Length; j++)
            {
                for (int k = 0; k < dimension3Length; k++)
                {
                    Console.WriteLine($"[{i}, {j}, {k}] = {array[i, j, k]}");
                }
            }
        }
    }

int[, ,] arr_3d = Generate_Random_Array(3, 2, 4);
Print_3D_Array (arr_3d);
