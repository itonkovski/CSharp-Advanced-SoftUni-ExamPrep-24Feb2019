using System;
using System.Linq;

namespace TronRacersAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];

            int firstPlayerRow = -1;
            int firstPlayerCol = -1;
            bool firstPlayerFound = false;

            int secondPlayerRow = -1;
            int secondPlayerCol = -1;
            bool secondPlayerFound = false;

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
            //for (int row = 0; row < matrix.Length; row++)
            //{
            //    char[] input = Console.ReadLine()
            //        .ToCharArray();
            //
            //    matrix[row] = new char[input.Length];
            //
            //    if (!firstPlayerFound && !secondPlayerFound)
            //    {
            //        for (int col = 0; col < input.Length; col++)
            //        {
            //            if (input[col] == 'f')
            //            {
            //                firstPlayerRow = row;
            //                firstPlayerCol = col;
            //                firstPlayerFound = true;
            //            }
            //            if (input[col] == 's')
            //            {
            //                secondPlayerRow = row;
            //                secondPlayerCol = col;
            //                secondPlayerFound = true;
            //            }
            //        }
            //    }
            //    
            //}

            while (true)
            {
                string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                string commandFirstPlayer = command[0];
                string commandSecondPlayer = command[1];

                if (commandFirstPlayer == "up")
                {
                    firstPlayerRow--;
                    if (firstPlayerRow < 0)
                    {
                        firstPlayerRow = matrix.Length-1;
                    }
                }
                else if (commandFirstPlayer == "down")
                {
                    firstPlayerRow++;
                    if (firstPlayerRow == matrix.Length)
                    {
                        firstPlayerRow = 0;
                    }
                }
                else if (commandFirstPlayer == "left")
                {
                    firstPlayerCol--;
                    if (firstPlayerCol < 0)
                    {
                        firstPlayerCol = matrix[firstPlayerRow].Length - 1;
                    }
                }
                else if (commandFirstPlayer == "right")
                {
                    firstPlayerCol++;
                    if (firstPlayerCol == matrix.Length)
                    {
                        firstPlayerCol = 0;
                    }
                }

                if (matrix[firstPlayerRow][firstPlayerCol] == 's')
                {
                    matrix[firstPlayerRow][firstPlayerCol] = 'x';

                    foreach (var row in matrix)
                    {
                        Console.WriteLine(string.Join("",row));
                    }
                    break;
                }
                else
                {
                    matrix[firstPlayerRow][firstPlayerCol] = 'f';
                }

                if (commandSecondPlayer == "up")
                {
                    secondPlayerRow--;
                    if (secondPlayerRow - 1 < 0)
                    {
                        secondPlayerRow = matrix.Length - 1;
                    }
                }
                else if (commandSecondPlayer == "down")
                {
                    secondPlayerRow++;
                    if (secondPlayerRow == matrix.Length)
                    {
                        secondPlayerRow = 0;
                    }
                }
                else if (commandSecondPlayer == "left")
                {
                    secondPlayerCol--;
                    if (secondPlayerCol < 0)
                    {
                        secondPlayerCol = matrix[secondPlayerRow].Length - 1;
                    }
                }
                else if (commandSecondPlayer == "right")
                {
                    secondPlayerCol++;
                    if (secondPlayerCol == matrix.Length)
                    {
                        secondPlayerCol = 0;
                    }
                }

                if (matrix[secondPlayerRow][secondPlayerCol] == 'f')
                {
                    matrix[secondPlayerRow][secondPlayerCol] = 'x';
                    foreach (var row in matrix)
                    {
                        Console.WriteLine(string.Join("", row));
                    }
                    break;
                }
                else
                {
                    matrix[secondPlayerRow][secondPlayerCol] = 's';
                }
            }
        }
    }
}
