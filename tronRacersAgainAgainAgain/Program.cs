using System;
using System.Linq;

namespace tronRacersAgainAgainAgain
{
    class Program
    {
        static char[][] matrix;

        static int firstPlayerRow;
        static int firstPlayerCol;

        static int secondPlayerRow;
        static int secondPlayerCol;

        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            matrix = new char[rows][];

            Initialize();

            while (true)
            {
                string[] directions = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string firstPlayerDirection = directions[0];
                string secondPlayerDirection = directions[1];

                if (firstPlayerDirection == "up")
                {
                    firstPlayerRow--;

                    if (firstPlayerRow < 0)
                    {
                        firstPlayerRow = matrix.Length - 1;
                    }
                }
                else if (firstPlayerDirection == "down")
                {
                    firstPlayerRow++;

                    if (firstPlayerRow == matrix.Length)
                    {
                        firstPlayerRow = 0;
                    }
                }
                else if (firstPlayerDirection == "left")
                {
                    firstPlayerCol--;

                    if (firstPlayerCol < 0)
                    {
                        firstPlayerCol = matrix[firstPlayerRow].Length - 1;
                    }
                }
                else if (firstPlayerDirection == "right")
                {
                    firstPlayerCol++;

                    if (firstPlayerCol == matrix[firstPlayerRow].Length)
                    {
                        firstPlayerCol = 0;
                    }
                }

                if (matrix[firstPlayerRow][firstPlayerCol] == 's')
                {
                    matrix[firstPlayerRow][firstPlayerCol] = 'x';
                    End();
                }
                else
                {
                    matrix[firstPlayerRow][firstPlayerCol] = 'f';
                }

                if (secondPlayerDirection == "up")
                {
                    secondPlayerRow--;

                    if (secondPlayerRow < 0)
                    {
                        secondPlayerRow = matrix.Length - 1;
                    }
                }
                else if (secondPlayerDirection == "down")
                {
                    secondPlayerRow++;

                    if (secondPlayerRow == matrix.Length)
                    {
                        secondPlayerRow = 0;
                    }
                }
                else if (secondPlayerDirection == "left")
                {
                    secondPlayerCol--;

                    if (secondPlayerCol < 0)
                    {
                        secondPlayerCol = matrix[secondPlayerRow].Length - 1;
                    }
                }
                else if (secondPlayerDirection == "right")
                {
                    secondPlayerCol++;

                    if (secondPlayerCol == matrix[secondPlayerRow].Length)
                    {
                        secondPlayerCol = 0;
                    }
                }

                if (matrix[secondPlayerRow][secondPlayerCol] == 'f')
                {
                    matrix[secondPlayerRow][secondPlayerCol] = 'x';
                    End();
                }
                else
                {
                    matrix[secondPlayerRow][secondPlayerCol] = 's';
                }
            }
        }

        private static void Initialize()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                char[] input = Console.ReadLine()
                    .ToCharArray();
                matrix[row] = new char[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row][col] = input[col];

                    if (matrix[row][col] == 'f')
                    {
                        firstPlayerRow = row;
                        firstPlayerCol = col;
                    }
                    else if (matrix[row][col] == 's')
                    {
                        secondPlayerRow = row;
                        secondPlayerCol = col;
                    }
                }
            }
        }

        private static void End()
        {
            //foreach (var row in matrix)
            //{
            //    Console.WriteLine(string.Join("", row));
            //}

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
            Environment.Exit(0);
        }
    }
}
