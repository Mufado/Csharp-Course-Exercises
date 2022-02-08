using System;

namespace First.Exercises.MatrixExercise
{
    class MatrixExerciseProgram
    {
        public void MatrixExercise()
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int m = int.Parse(dimensions[0]);
            int n = int.Parse(dimensions[1]);

            int[,] matrix = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < m ; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == value)
                    {
                        Console.WriteLine($"Position {i},{j}:");
                        if (j > 0)
                            Console.WriteLine($"Left: {matrix[i, j - 1]}");
                        if (i > 0)
                            Console.WriteLine($"Up: {matrix[i - 1, j]}");
                        if (j < n - 1)
                            Console.WriteLine($"Right: {matrix[i, j + 1]}");
                        if (i < m - 1)
                            Console.WriteLine($"Down: {matrix[i + 1, j]}");
                    }
                }
            }
        }
    }
}
