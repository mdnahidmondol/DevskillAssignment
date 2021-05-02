using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] jaggedArray4 = new int[][,]
            {
                new int [,] { { 1, 3}, { 5 , 7} },
                new int [,] { { 0, 2}, { 4, 6}, { 8, 10} },
                new int [,] { { 11,22}, { 99, 88}, { 0, 9} }
            };

            for (int i = 0; i < jaggedArray4.Length; i++)
            {
                for (int j = 0; j < jaggedArray4[i].GetLength(0); j++)
                {
                    for (int k = 0; k < jaggedArray4[j].Rank; k++)
                    {
                        Console.Write($"JaggedArray[{i}] [{j}, {k}]: {jaggedArray4[i][j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
          

        }
        
    }
}
